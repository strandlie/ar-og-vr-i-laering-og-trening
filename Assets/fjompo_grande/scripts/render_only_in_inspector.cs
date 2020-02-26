using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class render_only_in_inspector : MonoBehaviour
{
    public MeshRenderer target;

    void Start()
    {
        if (this.enabled) {
            target.enabled = false;
        }
    }

    void OnEnable()
    {
        target.enabled = false;
    }
    
    void OnDisable()
    {
        target.enabled = true;
    }
}
