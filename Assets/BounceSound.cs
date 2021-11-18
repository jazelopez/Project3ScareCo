using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceSound : MonoBehaviour
{
    public AudioSource bouncing;

    // Start is called before the first frame update
    void Start(){
    }

    // Update is called once per frame
    void Update(){
    }

    void OnCollisionEnter (Collision collision) {
        //Debug.Log($"{gameObject.name} is colliding with {collision.collider.name}");
        if (collision.relativeVelocity.magnitude > 0.5) {
            if (!bouncing.isPlaying) {
                bouncing.Play();
            }
        }
    }


}