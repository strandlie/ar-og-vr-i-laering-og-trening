using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using DigitalRuby.PyroParticles;

public class burnable_behaviour : MonoBehaviour {
    
    public GameObject  fire_asset;
    public float       fire_initial        = 10.0f;
    public float       fire_max            = 10.0f; // seconds untill at max
    public float       foam_effect         = -0.2f;
    public float       fizzle_sound_volume =  1.0f;
    public AudioClip   fizzle_sound;

    // internal state
    float       fire_current; // amount
    GameObject  fire_current_asset = null;

    // Start is called before the first frame update
    void Start() {
        fire_current = fire_initial;

        fizzle_sound.LoadAudioData();
        //Debug.Log("setup " + this.gameObject.name);    
        
        // sanity checks
        Assert.IsTrue(Vector3.up.y == 1);
        Assert.IsTrue(foam_effect < 0);
    }

    // Update is called once per frame
    private float fire_prev = 0; // 2cache4u
    void Update() {
        if (fire_current > 0) {
            if (fire_current < fire_max) fire_current += Time.deltaTime;
            if (fire_current > fire_max) fire_current = fire_max;
        }
        if (fire_current != fire_prev) {
            // toggle fire
            if (fire_current == 0) {
                fire_current_asset.GetComponent<FireConstantBaseScript>().Stop();
                fire_current_asset = null;
            } else if (fire_prev == 0) {
                fire_current_asset = Instantiate(
                    fire_asset, this.transform, false);
            }

            // scale fire
            if (fire_current_asset != null) {
                fire_current_asset.transform.localScale
                    = new Vector3(1, 2-2/(1+fire_current/fire_max), 1); // 2fancy4u
            }

            fire_prev = fire_current;
        }
    }

    // trigger handler
    void OnTriggerEnter(Collider collider) {
        // assumes the foam particle collision mesh is bound to a child object
        if (collider.transform.parent.gameObject.name.StartsWith("foam_particle")) {
            HandleFoamCollision(collider.transform.parent.gameObject);
        }
    }

    // when hit by foam
    void HandleFoamCollision(GameObject foam) {
        if (fire_current > 0) {
            fire_current += foam_effect; // foam_effect is negative
            AudioSource.PlayClipAtPoint(
                fizzle_sound,
                foam.transform.position,
                fizzle_sound_volume
            );
            Destroy(foam);
        }
        if (fire_current < 0) fire_current = 0;
    }

}
