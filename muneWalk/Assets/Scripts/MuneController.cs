/*
 * contains functions and variable
 * to move mune left and right across screen
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuneController : MonoBehaviour
{
    public Animator anim;

    // determines the speed at which mune moves left/right
    public float speedMune = 2.0f;

    // variable to store horizontal input
    public float horizontalInput;

    // Start is called before the first frame update
    void Start()
    {
        // now anim can trigger animations from Animator
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // variable contains horizontal axis numbers
        horizontalInput = Input.GetAxis("Horizontal");
        // Move Mune in the X direction
        // transformation is based on horizontalInput

        // mune walk animation triggered when right arrow pressed
        if (Input.GetKey(KeyCode.RightArrow))
        {
            // flip mune
            transform.rotation = Quaternion.Euler(0, 0, 0);
            // play walk animation
            anim.Play("muneWalk");
            // move object in the positive x-axis
            transform.Translate(Vector3.right * Time.deltaTime * speedMune * horizontalInput);
            
            
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            // flip mune
            transform.rotation = Quaternion.Euler(0, 180f, 0);
            // play walk animation
            anim.Play("muneWalk");
            // move object in the negative x-axis
            transform.Translate(Vector3.left * Time.deltaTime * speedMune * horizontalInput);
        }
    }
}
