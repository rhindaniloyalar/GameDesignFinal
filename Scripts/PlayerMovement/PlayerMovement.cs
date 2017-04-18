/*****************************PlayerMovement*********************************
 *Programmer: Christine Jordan
 *Class: PlayerMovement
 *Inheritance: NONE
 *Date Created: 11/7/15
 *Date Modified: 11/7/15
 *Project: Project Avenon
 *Purpose:
 *ChangeLog [11/7/15]
 ***************************************************************************/
using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float rotateSpeed = 5f;

    public KeyCode moveForward;
    public KeyCode moveLeft;
    public KeyCode moveRight;
    public KeyCode moveBack;
    public KeyCode jump;
    public KeyCode sprint;
    // public KeyCode attack;
    // public KeyCode defend;



    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(moveForward))
        {
            transform.Translate((Vector3.forward) * moveSpeed * Time.deltaTime);
        }

        if (Input.GetKey(moveLeft))
        {
            transform.Rotate((Vector3.up) * rotateSpeed);
            //transform.Translate((Vector3.left) * moveSpeed * Time.deltaTime);
        }

        if (Input.GetKey(moveRight))
        {
            transform.Rotate((Vector3.down) * rotateSpeed);
            //transform.Translate((Vector3.right) * moveSpeed * Time.deltaTime);
        }

        if (Input.GetKey(moveBack))
        {
            transform.Translate((Vector3.back) * moveSpeed * Time.deltaTime);
        }

        if (Input.GetKeyDown(jump))
        {

        }

        if (Input.GetKey(sprint))
        {
            moveSpeed = 20f;
        }

        if (!Input.GetKey(sprint))
        {
            moveSpeed = 10f;
        }
    }
}

