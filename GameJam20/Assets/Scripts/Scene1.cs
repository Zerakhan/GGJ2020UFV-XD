﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene1 : MonoBehaviour
{
    public bool follow_player;
    public GameObject Cam;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (follow_player)
        {
            Cam.transform.position = new Vector3(this.transform.position.x, 0, -10);
        }

    }
}
