using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuMusic : MonoBehaviour
{

    public GameObject Sound;
    // Start is called before the first frame update
    void Start()
    {
        Sound = GameObject.Find("SFX");
        Sound.GetComponent<sfwScript>().playMenuMusic();
    }

}
