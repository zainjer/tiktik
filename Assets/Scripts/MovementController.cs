using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MovementController : MonoBehaviour
{

    public GameObject playerA;
    public GameObject playerB;
    public Slider inputSlider;
    public float speed=5;
    private Rigidbody rbA,rbB;
    void Start()
    {
        rbA = playerA.GetComponent<Rigidbody>();
        rbB = playerB.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        var horizontalMovement = Input.GetAxis("Horizontal") * Time.deltaTime * speed;

        //--------------------------------------------------------------------------------------------------------------------------------------
        playerA.transform.Translate(horizontalMovement,0,0);
        playerB.transform.Translate(horizontalMovement*-1,0,0);
        //--------------------------------------------------------------------------------------------------------------------------------------
        rbA.velocity = rbB.velocity = Vector3.zero;

    }

    public void InputSliderValueChange()
    {
        var horizontalMovement = inputSlider.value; 

        
        playerA.transform.position = new Vector3(horizontalMovement,0,0);
        playerB.transform.position = new Vector3(horizontalMovement*-1,35f,0);
        
        rbA.velocity = rbB.velocity = Vector3.zero;
    }
}
