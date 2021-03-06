﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class create_and_snap_hose_between_two_anchors : MonoBehaviour {
    public GameObject anchor1;
    public GameObject anchor2;
    public GameObject hose_prefab;

    GameObject hose;

    // Start is called before the first frame update
    void Start() {
        hose = Instantiate(
            hose_prefab,
            Vector3.zero,
            Quaternion.identity,
            this.transform);
        update_hose_position();
    }

    // Update is called once per frame
    void Update() {
        update_hose_position();
    }

    private
    void update_hose_position() {
        Vector3 direction
            = anchor1.transform.position
            - anchor2.transform.position;

        // origin of cylinder is in center, therefore position is between the two anchors
        hose.transform.transform.position 
            = (anchor2.transform.position + anchor1.transform.position) / 2;

        // rotate according to direction vector
        hose.transform.rotation
            = Quaternion.LookRotation(direction, Vector3.up);

        // lenght equal to distance, basemodel is 2 units high
        
        hose.transform.localScale
            = new Vector3(1, 1, direction.magnitude/2 / (this.transform.localScale.magnitude/1.7320508075688772f));
    }
}
