﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Castle : MonoBehaviour
{
    public GameObject[,,] Blocks;
    public float cellSize = 0.5f;
    public int sizeX, sizeY, sizeZ;

    public void Start()
    {
        Blocks = new GameObject[sizeX,sizeY,sizeZ];
    }

    public Vector3 buildOnTheGrowndCoord(Vector3 pos)
    {
        return new Vector3((int)((pos.x-transform.position.x)/cellSize),0,(int)((pos.z - transform.position.z) / cellSize));
    }

    public Vector3 getPosByElement(Vector3 element)
    {
        return transform.position + element * cellSize;
    }

}