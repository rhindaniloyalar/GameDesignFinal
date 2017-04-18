/**************************PlayerController*********************************
 *Programmer: Christine Jordan
 *Class: PlayerController
 *Inheritance: Monobehaviour
 *Date Created: 11/7/15
 *Date Modified: 11/7/15
 *Project: Project Avenon
 *Purpose:
 *ChangeLog: [11/7/15] Created script. Added comment headers
 ***************************************************************************/
using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public float rotateSpeed;
    public float forwardSpeed;
    public float runSpeed;

    private CharacterController playerController;
/********************************Start***************************************
 * In:
 * Out:
 * Purpose: Use this for initialization
 * **************************************************************************/
    void Start ()
    {
        playerController = GetComponent<CharacterController>();
	}
/*********************************Upadate************************************
 * In:
 * Out:
 *Purpose: Update is called once per frame
 * **************************************************************************/
    void Update ()
    {
        if (Input.GetKeyDown("space") && playerController.isGrounded)
        {
            playerController.Move(Vector3.up);
        }

        transform.Rotate(0f, Input.GetAxis("Horizontal") * rotateSpeed, 0f); //Vector3 = x,y,z
        Vector3 forward = transform.TransformDirection(Vector3.forward);
        float speed = forwardSpeed * Input.GetAxis("Vertical");
        playerController.SimpleMove(speed * forward);

        if(Input.GetAxis("Run") == 1 && playerController.isGrounded)
        {
            runSpeed = forwardSpeed * 1.5f;
            forwardSpeed = runSpeed;
        }
	}
}
