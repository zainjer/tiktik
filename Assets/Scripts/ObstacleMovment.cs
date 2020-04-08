using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovment : MonoBehaviour
{
    public GameObject obstacleToRotate;
    public GameObject obstacleToMove;
    public float rotationSpeed; // Recommended speed 2
    public float movementSpeed; // Recommended speed 0.5
    public float LeftMostPoint = -7.4f;
    public float RightMostPoint = 7.4f;
    public float Height=0;

    private bool isMovingRight = true;
    void Update()
    {
        var t = obstacleToRotate.transform;
        t.Rotate(new Vector3(0,0,rotationSpeed));
        if (isMovingRight)
        {
            obstacleToMove.transform.position = Vector3.Lerp(obstacleToMove.transform.position, new Vector3(RightMostPoint, Height, 0), movementSpeed*Time.deltaTime);
        }
        else
        {
            obstacleToMove.transform.position = Vector3.Lerp(obstacleToMove.transform.position, new Vector3(LeftMostPoint, Height, 0), movementSpeed*Time.deltaTime);
        }

        var horizontalPosition = Mathf.Round(obstacleToMove.transform.position.x);
        if (horizontalPosition == Mathf.Round(RightMostPoint))
        {
            Debug.Log("Got to pos");
            isMovingRight = false;
        }else if (horizontalPosition == Mathf.Round(LeftMostPoint))
        {
            isMovingRight = true;
        }
    }
        
}

