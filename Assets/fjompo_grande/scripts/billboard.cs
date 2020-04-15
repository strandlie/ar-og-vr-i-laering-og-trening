using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class billboard : MonoBehaviour
{
    public Vector3 orientation = new Vector3(90, 0, 0);
    private GameObject playerController;
    private OVRCameraRig ovrCameraRig;

    // Start is called before the first frame update
    void Start()
    {
        playerController = GameObject.FindWithTag("GameController");
        face_camera();
        
    }

    // Update is called once per frame
    void Update()
    {
        face_camera();
    }

    void face_camera()
    {
        if (playerController != null)
        {
            OVRCameraRig ovrCameraRig = playerController.GetComponentInChildren<OVRCameraRig>();
            Vector3 dir = ovrCameraRig.centerEyeAnchor.position - this.transform.position;
            this.transform.rotation
                = Quaternion.LookRotation(dir, Vector3.up)
                * Quaternion.Euler(orientation);
        }
        
    }

}
