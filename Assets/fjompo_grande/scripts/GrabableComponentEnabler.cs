using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(OVRGrabbable))]
public class GrabableComponentEnabler : MonoBehaviour
{
    public MonoBehaviour componentToEnable = null;
    private OVRGrabbable grabbable;

    // Start is called before the first frame update
    void Start()
    {
        grabbable = GetComponent<OVRGrabbable>();
    }

    // Update is called once per frame
    void Update()
    {
        if (componentToEnable != null && grabbable.isGrabbed) {
            // TODO: determine if left or right controller
            // grabbable.isGrabbed.m_controller is what i'm looking for, but it's private
            if (OVRInput.Get(OVRInput.Axis1D.PrimaryHandTrigger, OVRInput.Controller.LTouch) > 0.7f || 
                OVRInput.Get(OVRInput.Axis1D.PrimaryHandTrigger, OVRInput.Controller.RTouch) > 0.7f) {
                    if (!componentToEnable.enabled) { componentToEnable.enabled = true; }
            } else {
                    if (componentToEnable.enabled) { componentToEnable.enabled = false; }
            }
        }
    }
}
