using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject ballPrefab;
    public GameObject playerA,playerB;
    void Start()
    {
        //Gravity Multiplied 
        Debug.Log("Gravity Multiplied by 3");
        Physics.gravity = Physics.gravity * 3;
        
        //Instantiate Ball
        Instantiate(ballPrefab, new Vector3(0, 5f, 0), Quaternion.identity);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (TopBottomWallsCollision.Exited)
        {
            BallExitHandler();
        }

        if (GravityDirectionChanger.GravityDirection == GravityDirectionChanger.DIRECTION_DOWN)
        {
            playerA.GetComponent<MeshRenderer>().material.color = Color.yellow;
            playerB.GetComponent<MeshRenderer>().material.color = Color.blue;
        }
        else if (GravityDirectionChanger.GravityDirection == GravityDirectionChanger.DIRECTION_UP)
        {
            playerB.GetComponent<MeshRenderer>().material.color = Color.yellow;
            playerA.GetComponent<MeshRenderer>().material.color = Color.blue;
        }
        else
        {
            Debug.Log("Cant find a gravity direction. Goto script GravityDirectionChanger ");
        }
    }

    [ContextMenu("Ball Exit Handler")]
    void BallExitHandler()
    {
        //Write scoring or GameOver logic here
        Debug.Log("Ball Exited Arena");
        TopBottomWallsCollision.Exited = false;
        Instantiate(ballPrefab, new Vector3(0, 5, 0), Quaternion.identity);
    }
}
