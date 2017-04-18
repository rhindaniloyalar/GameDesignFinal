/**************************CameraController*********************************
 *Programmer: Christine Jordan
 *Class: CameraController
 *Inheritance: MonoBehaviour
 *Date Created: 11/7/15
 *Date Modified: 11/7/15
 *Project: Project Avenon
 *Purpose:
 *ChangeLog: [11/7/15] When left mouse button is held down
 ***************************************************************************/
using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour
{
    public Transform cameraTarget;
    private float x = 0.0f;
    private float y = 0.0f;

    private int mouseXSpeedMod = 5;
    private int mouseYSpeedMod = 3;

    public float maxViewDistance = 25f;   //how far out the camera can zoom
    public float minViewDistance = 1f;    //how far in the camera can zoom
    public int zoomRate = 30;             //how fast camera can zoom
    public int lerpRate = 5;              //how fast the camera adjusts itself behind the player while moving  
    private float distance;               //starting distance away from players
    private float desiredDistance;        //used for calculations
    private float correctedDistance;      //used for calculations

    // Use this for initialization
    void Start ()
    {
        Vector3 angles = transform.eulerAngles; //
        x = angles.x;
        y = angles.y;              
    }
	
	// Update is called once per frame
	void LateUpdate ()
    {
        if (Input.GetMouseButton(0))
        {
            x += Input.GetAxis("Mouse X") * mouseXSpeedMod;
            y -= Input.GetAxis("Mouse Y") * mouseYSpeedMod;

        }
        else if (Input.GetAxis("Vertical") != 0 || Input.GetAxis("Horizontal") != 0) //If either vertical (z) or horizontal (x) movement bring camera back behind player
        {
            float targetRotationAngle = cameraTarget.eulerAngles.y;
            float cameraRotationAngle = transform.eulerAngles.y;
            x = Mathf.LerpAngle(cameraRotationAngle, targetRotationAngle, lerpRate * Time.deltaTime); //slowly dertemine a value and move towards that value

        }

        y = ClampAngle(y, -50, 80);

        Quaternion rotation = Quaternion.Euler(y, x, 0);

        //calculates distance the player wants camera
        desiredDistance -= (Input.GetAxis("Mouse ScrollWheel") 
            * Time.deltaTime * zoomRate *Mathf.Abs(desiredDistance));
        desiredDistance = Mathf.Clamp(desiredDistance, minViewDistance, 
            maxViewDistance);

        correctedDistance = desiredDistance;

        //(x,y,z) * (0,1,0) * (angle in degrees)
        Vector3 pos = cameraTarget.position - (rotation * 
            Vector3.forward * desiredDistance);

        transform.rotation = rotation; 
        transform.position = pos;        
	}

    private static float ClampAngle(float angle, float min, float max)
    {
        if (angle < -360)
            angle += 360;
        if (angle > 360)
            angle -= 360;
        return Mathf.Clamp(angle, min, max);        
    }
}
