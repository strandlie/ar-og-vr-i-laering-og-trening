using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class die_at_deathplane : MonoBehaviour
{
    public float depth = 20f;
    
    // Start is called before the first frame update
    void Start()
    {
        Assert.IsTrue(Vector3.up.y == 1f);
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.y < -depth)
        {
            Destroy(this.gameObject);
        }
    }
}
