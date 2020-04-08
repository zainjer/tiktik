using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GravityDirectionChanger : MonoBehaviour
{

    public static int DIRECTION_DOWN = -1;
    public static int DIRECTION_UP = 1;
    public static int GravityDirection = DIRECTION_DOWN;
    public GameObject ballPrefab;

    private void Start()
    {
    }

    private void OnTriggerEnter(Collider other)
    {

        var ball = FindObjectOfType<Node_Ball>().gameObject;

        if (other.gameObject != ball) return;
        
        GravityDirection = GravityDirection == DIRECTION_DOWN ? DIRECTION_UP : DIRECTION_DOWN;
        Physics.gravity = Physics.gravity * -1;
    }
}

