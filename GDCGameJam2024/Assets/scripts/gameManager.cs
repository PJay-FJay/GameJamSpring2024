using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gameManager : MonoBehaviour
{

    public gameOver gameOver;
    public GameObject[] spt;
    public GameObject enemy, tank, speed, beetle, player;
    public int random;
    private float tSp = 1.1f;

    public GameObject Sound;

    public void GameOver(){
        gameOver.SetUp();
    }

    public void restart(){
        gameOver.StartUp();
        Time.timeScale = 1;
        SceneManager.LoadScene("TestMap");
    }

    void Spawn(){
        //print("MewoForSpawn");
        //random = Random.Range(1, 1);
        int health = player.GetComponent<playerHealth>().currHP;
        random = Random.Range(1,9);
        
        if(health <= 0){
            random = 10;
        }

        //Basic enemy
        if(random >= 2 && random < 5){
            int sTar = Random.Range(1,8);
            Instantiate(enemy, spt[sTar-1].transform.position, Quaternion.identity);
            Invoke("Spawn", tSp);

        //Speedy Enemy
        } else if(random >= 5 && random < 8){
            int sTar = Random.Range(1,8);
            Instantiate(speed, spt[sTar-1].transform.position, Quaternion.identity);
            sTar = Random.Range(1,8);
            Instantiate(speed, spt[sTar-1].transform.position, Quaternion.identity);
            Invoke("Spawn", tSp);

        //Tanky Enemy
        } else if (random == 8){
            int sTar = Random.Range(1,8);
            Instantiate(tank, spt[sTar-1].transform.position, Quaternion.identity);
            Invoke("Spawn", tSp);
        } else if (random == 1){
            random = Random.Range(1,4);
                if(random == 1){tSp -= 0.1f;}
            Invoke("Spawn", tSp);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        Invoke("Spawn", tSp);
        Sound = GameObject.Find("SFX");
        Sound.GetComponent<sfwScript>().playGameMusic();
    }

    // Update is called once per frame
    void Update()
    {
        int heath = player.GetComponent<playerHealth>().currHP;
        if(heath <= 0){
            Sound.GetComponent<sfwScript>().stopGameMusic();
            GameOver();
        }
    }
}
