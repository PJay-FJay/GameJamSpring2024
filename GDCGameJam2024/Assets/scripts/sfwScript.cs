using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sfwScript : MonoBehaviour
{
    //SFX
    public AudioSource pew;
    public AudioSource Ehurt;
    public AudioSource Phurt;
    public AudioSource Eded;
    public AudioSource Pded;

    //Music
    public AudioSource gameMusic;
    public AudioSource menuMusic;
    public AudioSource gameOverMusic;
    public AudioSource HTPMusic;

    //SFX
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


    //MUSIC
    public void playGameMusic(){
        gameMusic.Play();
    }
    public void stopGameMusic(){
        gameMusic.Stop();
    }

        public void playGOM(){
            print("HUH");
            gameOverMusic.Play();
        }
        public void stopGOM(){
            gameOverMusic.Stop();
        }

    public void playMenuMusic(){
        menuMusic.Play();
    }
    public void stopMenuMusic(){
        menuMusic.Stop();
    }

        public void playHTPMusic(){
            HTPMusic.Play();
        }
        public void stopHTPMusic(){
            HTPMusic.Stop();
        }
    
}
