using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class HeightmapGenerator
{
    public static float[,] Sin1D(int width, float scale, float height)
    {
        // suggested 0.06f, 0.05f
        float[,] heightmap = new float[width,width];

        for (int y = 0; y < width; y++)
        {
            for (int x = 0; x < width; x++)
            {
                heightmap[y,x] = height * (0.5f * (1 + Mathf.Sin(scale*(float)x)));
            }
        }

        return heightmap;
    }
}
