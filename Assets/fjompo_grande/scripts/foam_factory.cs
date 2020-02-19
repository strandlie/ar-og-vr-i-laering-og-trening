using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class foam_factory : MonoBehaviour
{
    public GameObject object_to_create;
    public Vector3    initial_velocity = Vector3.up * 15f; // units per second
    public float      period           = 0.3f;  
//    public float      stdev            = 0f; // not implemented

    // state
    float time_last_created;

    // Start is called before the first frame update
    void Start()
    {
        time_last_created = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time - time_last_created > period) {
            time_last_created = Time.time;
            
            GameObject particle = Instantiate(
                object_to_create,
                this.transform.position,
                this.transform.rotation);
            
            particle.GetComponent<Rigidbody>().velocity = initial_velocity;
        }
    }
}
