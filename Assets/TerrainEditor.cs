using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainEditor : MonoBehaviour
{
    private int width;
    private TerrainData terrainData;
    

    private void Awake() 
    {
        terrainData = GetComponentInChildren<Terrain>().terrainData;
        width = terrainData.heightmapResolution;
        
        Flatten();
        float[,] heightmap = HeightmapGenerator.Sin1D(width, 0.06f, 0.05f);
        terrainData.SetHeights(0,0, heightmap);
        
    }


    private void Flatten()
    {
        float[,] heightmap = new float[width,width];
        
        terrainData.SetHeights(0,0, heightmap);
    }


}
