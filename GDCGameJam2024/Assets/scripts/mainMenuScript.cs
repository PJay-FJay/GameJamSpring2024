using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class mainMenuScript : MonoBehaviour
{

    public void GameStart(){
        //Sound.GetComponent<sfwScript>().stopMenuMusic();
        SceneManager.LoadScene("TestMap");
    }

    public void HowToMenu(){}
    public void Exit(){}
}
