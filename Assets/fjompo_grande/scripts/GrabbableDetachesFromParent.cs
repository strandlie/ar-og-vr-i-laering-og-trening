using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabbableDetachesFromParent : OVRGrabbable
{
    public MonoBehaviour enableOnDetach1 = null;
    public MonoBehaviour enableOnDetach2 = null;
    public MonoBehaviour enableOnDetach3 = null;
    public MonoBehaviour enableOnDetach4 = null;
    public MonoBehaviour enableOnDetach5 = null;


    protected override void Start()
    {
        if (enableOnDetach1 != null) enableOnDetach1.enabled = false;
        if (enableOnDetach2 != null) enableOnDetach2.enabled = false;
        if (enableOnDetach3 != null) enableOnDetach3.enabled = false;
        if (enableOnDetach4 != null) enableOnDetach4.enabled = false;
        if (enableOnDetach5 != null) enableOnDetach5.enabled = false;

        base.Start()
    }

	public override
    void GrabBegin(OVRGrabber hand, Collider grabPoint)
    {
        this.transform.parent = null;

        if (enableOnDetach1 != null) enableOnDetach1.enabled = true;
        if (enableOnDetach2 != null) enableOnDetach2.enabled = true;
        if (enableOnDetach3 != null) enableOnDetach3.enabled = true;
        if (enableOnDetach4 != null) enableOnDetach4.enabled = true;
        if (enableOnDetach5 != null) enableOnDetach5.enabled = true;

        base.GrabBegin(hand, grabPoint);
    }
}

