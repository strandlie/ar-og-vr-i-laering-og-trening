using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instance_factory : MonoBehaviour
{
    public GameObject object_to_create;
    public Vector3    initial_velocity = Vector3.up * 15f; // units per second
    public float      frequency        = 100;
    public Vector3    stdev_rotation   = new Vector3(10, 0, 10);
    public float      stdev_period     = 0;

    // state
    float time_for_next_instance;

    // Start is called before the first frame update
    void Start() {
        time_for_next_instance = Time.time;
    }

    // Update is called once per frame
    void Update() {
        while (Time.time > time_for_next_instance) {
            time_for_next_instance += 1f/frequency + stdev_period*gaussian();
            make_instance();
        }
    }

    void OnDisable() {
        // ( ͡° ͜ʖ ͡°)
    }

    void OnEnable() {
        // let's not force the script to "catch up"
        time_for_next_instance = Time.time;
    }

    private
    void make_instance() {
        GameObject instance = Instantiate(
            object_to_create,
            this.transform.position,
            Quaternion.identity);

        instance.GetComponent<Rigidbody>().velocity
            = this.transform.rotation
            * Quaternion.Euler(
                stdev_rotation.x * gaussian(),
                stdev_rotation.y * gaussian(),
                stdev_rotation.z * gaussian())
            * initial_velocity;
    }

    private static
    float gaussian() {
        float v1, v2, s;
        do {
            v1 = 2.0f * Random.Range(0f,1f) - 1.0f;
            v2 = 2.0f * Random.Range(0f,1f) - 1.0f;
            s = v1 * v1 + v2 * v2;
        } while (s >= 1.0f || s == 0f);
    
        s = Mathf.Sqrt((-2.0f * Mathf.Log(s)) / s);
    
        return v1 * s;
    }
}
