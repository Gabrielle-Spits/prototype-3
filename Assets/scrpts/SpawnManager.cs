﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstakelPrefab;
    private Vector3 spawnPos = new Vector3(25, 0, 0);
    private float startDelay = 2;
    private float repeatRate = 2;

    private playercontroler playerControllerScript;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstakel", startDelay, repeatRate);
        playerControllerScript =
            GameObject.Find("player").GetComponent<playercontroler>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnObstakel()
    {
        if (playerControllerScript.gameOver == false)
        {
            Instantiate(obstakelPrefab, spawnPos, obstakelPrefab.transform.rotation);
        }
    }
}
