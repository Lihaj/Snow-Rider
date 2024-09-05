using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class crashDetector : MonoBehaviour
{
    [SerializeField] float loadDelay = 0.5f;
    [SerializeField] ParticleSystem crasheffect;
   
    [SerializeField] AudioClip crashSFX;
    bool hascrashed=false;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Ground"&& hascrashed==false)
        {
            hascrashed=true;
            GetComponent<PlayerContorller>().Disablecontrol();
            FindObjectOfType<SurfaceEffector2D>().speed=0.1f;
            GetComponent<DustTail>().playerfall=true;
            crasheffect.Play();
            GetComponent<AudioSource>().PlayOneShot(crashSFX);
            Invoke("ReloadScene", loadDelay);
        }
    }
    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }  
}
