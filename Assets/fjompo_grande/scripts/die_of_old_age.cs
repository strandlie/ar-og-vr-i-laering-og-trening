using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class die_of_old_age : MonoBehaviour
{
    public float lifetime = 60;

    float epoch;

    void Start()
    {
        epoch = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time - epoch > lifetime)
        {
            Destroy(this.gameObject);
        }
    }
}
