using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class burnable_behaviour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("setup " + this.gameObject.name);    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // when hit by foam
    void OnTriggerEnter(Collider other)
    {
        //Debug.Log("enter " + other.transform.parent.gameObject.name);
        if (other.transform.parent.gameObject.name.StartsWith("foam_particle"))
        {
            Destroy(other.transform.parent.gameObject);
        }
    }


}
