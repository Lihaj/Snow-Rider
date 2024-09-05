using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustTail : MonoBehaviour
{
    public bool playerfall=false;
    [SerializeField]ParticleSystem dustTail;
    void OnCollisionEnter2D(Collision2D other) {
     if(other.gameObject.tag=="Ground" && playerfall==false){
        dustTail.Play();
     }   
    }

    private void OnCollisionExit2D(Collision2D other) {
        if(other.gameObject.tag=="Ground"){
            dustTail.Stop();
        }
    }
}
