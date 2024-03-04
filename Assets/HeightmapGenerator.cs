using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class HeightmapGenerator
{
    public static float[,] Sin1D(int width, float scale, float height)
    {
        // suggested scale:0.06f, height:0.05f
        float[,] heightmap = new float[width,width];

        for (int y = 0; y < width; y++)
        {
            for (int x = 0; x < width; x++)
            {
                heightmap[y,x] = height * (0.5f * (1 + Mathf.Sin(scale*x)));
            }
        }

        return heightmap;
    }


    public static float[,] Sin2D(int width, float scale, float height)
    {
        // suggested scale:0.06f, height:0.05f
        float[,] heightmap = new float[width,width];

        for (int y = 0; y < width; y++)
        {
            for (int x = 0; x < width; x++)
            {
                heightmap[y,x] = height * (0.25f * (2 + Mathf.Sin(scale*x) + Mathf.Sin(scale*y)));
            }
        }

        return heightmap;
    }


    public static float[,] Perlin1Layer(int width, float scale, float height)
    {
        // suggested 0.06f, 0.05f
        float[,] heightmap = new float[width,width];

        for (int y = 0; y < width; y++)
        {
            for (int x = 0; x < width; x++)
            {
                heightmap[y,x] = height * Mathf.PerlinNoise(scale*x,scale*y);
            }
        }

        return heightmap;
    }
}
