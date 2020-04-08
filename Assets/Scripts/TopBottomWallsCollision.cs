using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopBottomWallsCollision : MonoBehaviour
{

    public static bool Exited;
    private void OnCollisionEnter(Collision other)
    {
        Exited = true;
        Destroy(other.gameObject); 
    }
}
