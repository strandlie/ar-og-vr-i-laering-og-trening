using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class brannhydrant_hose_snap : MonoBehaviour {
    Transform head, nose; // empty objects
    GameObject hose; // i make this

    // Start is called before the first frame update
    void Start() {
        // anchors:
        foreach (Transform t in this.GetComponentInChildren<Transform>()) {
            if (t.gameObject.name == "head") head = t;
            if (t.gameObject.name == "nose") nose = t;
        }

        // hose object
        hose = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        hose.name = "_" + this.gameObject.name + "_hose";
    }

    // Update is called once per frame
    void Update() {
        Vector3 direction = head.position - nose.position;

        // origin of cylinder is in center, therefore position is between the two anchors
        hose.transform.position = (nose.position + head.position) / 2;

        // rotate according to direction vector
        hose.transform.rotation
            = Quaternion.LookRotation(direction, Vector3.up)
            * Quaternion.Euler(90, 0, 0);

        // lenght equal to distance, basemodel is 2 units high
        hose.transform.localScale = new Vector3(0.1f, direction.magnitude/2, 0.1f);
    }
}
