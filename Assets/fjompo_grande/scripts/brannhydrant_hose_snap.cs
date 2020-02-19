using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class brannhydrant_hose_snap : MonoBehaviour {
    public GameObject anchor1;
    public GameObject anchor2;

    GameObject hose;

    // Start is called before the first frame update
    void Start() {
        hose = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        hose.name = "_" + this.gameObject.name + "_hose";
    }

    // Update is called once per frame
    void Update() {
        Vector3 direction = anchor1.transform.position - anchor2.transform.position;

        // origin of cylinder is in center, therefore position is between the two anchors
        hose.transform.transform.position = (anchor2.transform.position + anchor1.transform.position) / 2;

        // rotate according to direction vector
        hose.transform.rotation
            = Quaternion.LookRotation(direction, Vector3.up)
            * Quaternion.Euler(90, 0, 0);

        // lenght equal to distance, basemodel is 2 units high
        hose.transform.localScale = new Vector3(0.1f, direction.magnitude/2, 0.1f);
    }
}
