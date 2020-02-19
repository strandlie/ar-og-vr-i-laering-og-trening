using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class billboard : MonoBehaviour
{
    public Vector3 orientation = new Vector3(90, 0, 0);
    
    // Start is called before the first frame update
    void Start()
    {
        face_camera();
    }

    // Update is called once per frame
    void Update()
    {
        face_camera();
    }

    void face_camera()
    {
        this.transform.rotation 
            = Quaternion.LookRotation(Camera.main.transform.position, Vector3.up)
            * Quaternion.Euler(orientation);
    }

}
