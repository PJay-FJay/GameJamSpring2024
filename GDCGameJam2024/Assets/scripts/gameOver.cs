using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameOver : MonoBehaviour
{
    public GameObject Score;
    public TMP_Text finText;

    public void StartUp(){
        gameObject.SetActive(false);
    }

    public void SetUp(){
        gameObject.SetActive(true);
        Score = GameObject.Find("Score");
        
        int fin = Score.GetComponent<score>().getPts();
        finText.text = fin.ToString() + " Points";
    }

    public void Reset(){
        SceneManager.LoadScene("TestMap");
    }

    public void Exit(){
        SceneManager.LoadScene("mainMenu");
    }
}
