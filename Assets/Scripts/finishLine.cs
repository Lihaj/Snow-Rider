using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class finishLine : MonoBehaviour
{
    [SerializeField] float loadDelay=0.5f;
    [SerializeField] ParticleSystem finisheffect;
 void OnTriggerEnter2D(Collider2D other) {
    if(other.tag == "Player"){
        finisheffect.Play();
        GetComponent<AudioSource>().Play();
        Invoke("ReloadScene",loadDelay);
    }
 }
 void ReloadScene(){
    SceneManager.LoadScene(0);
 }
}
