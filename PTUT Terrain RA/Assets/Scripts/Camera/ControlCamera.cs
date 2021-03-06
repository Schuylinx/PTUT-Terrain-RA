﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlCamera : MonoBehaviour {

    private int CHUNK_SIZE;
    private int TERRAIN_SIZE;
    private int terrainObjectSize;
    private Camera mainCamera;

	// Use this for initialization
	void Start () {
        GameObject terrain = GameObject.Find("Terrain");
        CHUNK_SIZE = terrain.GetComponent<GenerateTerrain>().getChunkSize();
        TERRAIN_SIZE = terrain.GetComponent<GenerateTerrain>().getTerrainSize();
        terrainObjectSize = CHUNK_SIZE * TERRAIN_SIZE;

        mainCamera = Camera.main;
        mainCamera.transform.SetPositionAndRotation(new Vector3(-30.376f, 108.298f, -116.26f), Quaternion.Euler(45.955f, 53.065f, 4.958f));

    }
	
	// Update is called once per frame
	void Update () {

        if(Input.GetKey(KeyCode.LeftControl) || Input.GetKey(KeyCode.RightControl))
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                mainCamera.transform.Rotate(new Vector3((float)0.5, 0, 0));
            }else if (Input.GetKey(KeyCode.DownArrow))
            {
                mainCamera.transform.Rotate(new Vector3((float)-0.5, 0, 0));
            }
            else if (Input.GetKey(KeyCode.LeftArrow))
            {
                mainCamera.transform.Rotate(new Vector3(0, (float)-0.5, 0));
            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                mainCamera.transform.Rotate(new Vector3(0, (float)0.5, 0));
            }
        }
        else
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                mainCamera.transform.Translate(new Vector3(0, 0, (float)0.5));
            }
            else if (Input.GetKey(KeyCode.DownArrow))
            {
                mainCamera.transform.Translate(new Vector3(0, 0, (float)-0.5));
            }
            else if (Input.GetKey(KeyCode.LeftArrow))
            {
                mainCamera.transform.Translate(new Vector3((float)-0.5, 0, 0));
            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                mainCamera.transform.Translate(new Vector3((float)0.5, 0, 0));
            }
        }
		
	}
}
