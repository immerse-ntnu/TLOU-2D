using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

namespace TLOU2D.game.world{
    public class Chunk
    {

        public static float width = (float)(5.12f * 0.33f / Math.Sqrt(2.0));
        public static float height = width;
        
        public int gridX { get; private set; }

        public int gridY { get; private set; }

        public SpriteRenderer renderReference { get; private set; }

        public Collider2D collider;
        
        public Chunk(int x, int y, SpriteRenderer renderer)
        {
            gridX = x;
            gridY = y;
            renderReference = renderer;
        }

        public bool isWithinChunks(Transform transform, int chunksAway)
        {
            float diffX = transform.position.x - (gridX - 2) * width;
            float diffY = transform.position.y - (gridY - 2) * height;
            return Math.Abs(diffX) / width <= chunksAway && Math.Abs(diffY) / height <= chunksAway;
        }
    }
}