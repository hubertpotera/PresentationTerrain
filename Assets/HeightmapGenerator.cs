using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class HeightmapGenerator
{
    public static float[,] Sin1D(int width, float scale=0.06f, float height=0.05f)
    {
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


    public static float[,] Sin2D(int width, float scale=0.06f, float height=0.05f)
    {
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


    public static float[,] Random(int width, int seed=0)
    {
        System.Random rng = new(seed);
        float[,] heightmap = new float[width,width];

        for (int y = 0; y < width; y++)
        {
            for (int x = 0; x < width; x++)
            {
                heightmap[y,x] = rng.Next(0,100) / 10000f;
            }
        }

        return heightmap;
    }


    public static float[,] Perlin1Layer(int width, float scale=0.2f, float height=0.005f)
    {
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


    public static float[,] PerlinLayered(int width, float scale=0.2f, float height=0.005f, 
        int octaves=4, float lacunarity=2.0f, float persistance=0.5f)
    {
        float[,] heightmap = new float[width,width];

        for (int i = 0; i < octaves; i++)
        {
            for (int y = 0; y < width; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    heightmap[y,x] = height * Mathf.PerlinNoise(scale*x,scale*y);
                    //TODO change
                }
            }

            //TODO *= lacunarity, persistance
        }

        return heightmap;
    }
}
