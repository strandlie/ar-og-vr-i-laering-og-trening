using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class burnable_behaviour : MonoBehaviour
{
    public AudioClip fizzle_sound;
    public float     fizzle_sound_volume = 1.0f;


    // Start is called before the first frame update
    void Start() {
        fizzle_sound.LoadAudioData();
        //Debug.Log("setup " + this.gameObject.name);    
    }

    // Update is called once per frame
    void Update() {
        
    }

    // when hit by foam
    void OnTriggerEnter(Collider other)
    {
        //Debug.Log("enter " + other.transform.parent.gameObject.name);
        if (other.transform.parent.gameObject.name.StartsWith("foam_particle"))
        {
            AudioSource.PlayClipAtPoint(
                fizzle_sound, other.transform.position, fizzle_sound_volume);
            Destroy(other.transform.parent.gameObject);
        }
    }


}
