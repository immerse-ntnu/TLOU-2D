using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chunk : MonoBehaviour
{
    public int gridX { get; private set; }

    public int gridY { get; private set; }

    public SpriteRenderer renderReference { get; private set; }

    public Chunk(int x, int y, SpriteRenderer renderer)
    {
        gridX = x;
        gridY = y;
        renderReference = renderer;
    }
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }
}
