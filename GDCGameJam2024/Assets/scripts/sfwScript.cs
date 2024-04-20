using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sfwScript : MonoBehaviour
{
    public AudioSource pew;
    public AudioSource Ehurt;
    public AudioSource Phurt;
    public AudioSource Eded;
    public AudioSource Pded;

    public void playPew(){
        pew.Play();
    }

    public void playEhurt(){
        Ehurt.Play();
    }
    public void playPhurt(){
        Phurt.Play();
    }
    public void playEded(){
        Eded.Play();
    }
    public void playPded(){
        Pded.Play();
    }
    
}
