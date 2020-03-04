using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorBehavior : MonoBehaviour
{// Smoothly open a door
    public float smalldoorOpenAngle = 90.0f;
    public float openSpeed = 2.0f;

    bool open = false;
    bool enter = true;

    float defaultRotationAngle;
    float currentRotationAngle;
    float openTime = 0;


    // Start is called before the first frame update
    void Start()
    {
        defaultRotationAngle = transform.localEulerAngles.y;
        currentRotationAngle = transform.localEulerAngles.y;

        
    }
    //Main Function
    // Update is called once per frame
    void Update()
    {
        if (openTime < 1)
        {
            openTime += Time.deltaTime * openSpeed;
        }
        transform.localEulerAngles = new Vector3(
            transform.localEulerAngles.x,
            Mathf.LerpAngle(currentRotationAngle, 
            defaultRotationAngle + (open ? smalldoorOpenAngle : 0), openTime), 
            transform.localEulerAngles.z
        );

        if (Input.GetKeyDown(KeyCode.F) && enter)
        {

            open = !open;
            currentRotationAngle = transform.localEulerAngles.y;
            openTime = 0;
        }

    }
}
