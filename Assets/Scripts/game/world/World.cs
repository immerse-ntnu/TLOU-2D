using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TLOU2D.game.world
{

    public class World : MonoBehaviour
    {
        [SerializeField] private SpriteRenderer grass_tile_prefab;
        [SerializeField] private Transform tiles_holder;
        public List<Chunk> chunks = new List<Chunk>();

        public static World INSTANCE
        {
            get;
            private set;
        }

        // Start is called before the first frame update
        void Start()
        {
            INSTANCE = this;
            Time.timeScale = 1;
            LoadChunks();
        }

        public static int width = 20;
        public static int height = 20;

        void LoadChunks()
        {

            for (int i = -width / 2; i <= width / 2; i++)
            {
                for (int j = -height / 2; j <= height / 2; j++)
                {
                    int trueGridX = (i - width / 2);
                    int trueGridY = (j - height / 2);
                    if (!(trueGridX == 0 && trueGridY == 0))
                    {
                        // may remove when we launch game.
                        Vector3 pos = new Vector3(Chunk.width * trueGridX, Chunk.height * trueGridY, 10);
                        SpriteRenderer renderer = Instantiate(grass_tile_prefab, tiles_holder);
                        renderer.transform.position = pos;
                        Chunk newChunk = new Chunk(i, j, renderer);
                        chunks.Add(newChunk);
                    }
                }

            }
        }

        public void pauseWorld(bool val)
        {
            Time.timeScale = val ? 0 : 1;
            Debug.Log(Time.timeScale);
        }
        [SerializeField] private Transform player;

        // Update is called once per frame
        private void Update()
        {
            List<Chunk> keep = new List<Chunk>();
            int gridOffsetX = (int)(player.position.x / Chunk.width);
            int gridOffsetY = (int)(player.position.y / Chunk.height);
            for (int i = -width / 2; i <= width / 2; i++)
            {
                for (int j = -height / 2; j <= height / 2; j++)
                {
                    int realI = i + gridOffsetX;
                    int realJ = j + gridOffsetY;
                    Chunk found = null;
                    foreach (Chunk chunk in chunks)
                    {
                        if (chunk.gridX == realI && chunk.gridY == realJ)
                        {
                            found = chunk;
                            keep.Add(found);
                        }
                    }

                    if (found is null)
                    {
                        // may remove when we launch game.
                        Vector3 pos = new Vector3(Chunk.width * realI, Chunk.height * realJ, 10);
                        SpriteRenderer renderer = Instantiate(grass_tile_prefab, tiles_holder);
                        renderer.transform.position = pos;
                        Chunk newChunk = new Chunk(realI, realJ, renderer);
                        chunks.Add(newChunk);
                        keep.Add(newChunk);
                    }
                }
            }

            List<Chunk> forRemoval = new List<Chunk>();
            foreach (Chunk chunk in chunks)
            {
                chunk.renderReference.transform.position = new Vector3(
                    chunk.renderReference.transform.position.x, chunk.renderReference.transform.position.y,
                    player.position.z + 10);
                if (!keep.Contains(chunk))
                {
                    forRemoval.Add(chunk);
                }
            }

            foreach (Chunk chunk in forRemoval)
            {
                chunks.Remove(chunk);
                Destroy(chunk.renderReference);
            }
        }
    }
}