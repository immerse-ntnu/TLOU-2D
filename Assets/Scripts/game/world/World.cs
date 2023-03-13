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

        void LoadChunks()
        {
            int width = 50;
            int height = 50;
            float gap = 0.05f;
            float halfwidth = 5.7f + gap;
            float halfheight = 5.7f / Mathf.Sqrt(2.0f) + gap;
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    Vector3 pos = new Vector3(halfwidth * (i - width  / 2), halfheight * (j - height  / 2), 10);
                    SpriteRenderer renderer = Instantiate(grass_tile_prefab, tiles_holder);
                    renderer.transform.position = pos;
                    chunks.Add(new Chunk(i, j, renderer));
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
            foreach (Chunk chunk in chunks)
            {
                chunk.renderReference.transform.position = new Vector3(chunk.renderReference.transform.position.x, chunk.renderReference.transform.position.y, player.position.z + 10);
            }
        }
    }
}