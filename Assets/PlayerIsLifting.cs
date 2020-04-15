using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using static OVRHand;

public class PlayerIsLifting : MonoBehaviour
{
    //OVRHand[] hands;
    bool isIndexFingerPinching = false;
    // Start is called before the first frame update
    void Start()
    {
       //hands = GetComponents<OVRHand>();
     
    }
    
    // Update is called once per frame
    void Update()
    {
        Debug.Log("");
        //Debug.Log("HandLogInstance: " + hands[0].gameObject.tag);
        //Debug.Log("Is pinching: " + hands[0].GetFingerIsPinching(HandFinger.Index));
        /*Debug.Log("HandLogInstance: " + hands[1].tag);
        Debug.Log("Is pinching: " + hands[1].GetFingerIsPinching(HandFinger.Index));
        Debug.Log("####### ");

        if (isIndexFingerPinching) {
            Debug.Log("IndexFinger is pinching");
        }
        */
       
    }
}
