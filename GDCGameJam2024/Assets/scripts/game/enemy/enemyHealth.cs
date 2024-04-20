using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyHealth : MonoBehaviour
{

    public int maxHP = 3;
    public int currHP;

    private BoxCollider2D myBC;
    private SpriteRenderer mySR;

    public GameObject Score;
    public GameObject Sound;

    //public GameObject enemy;

    void TakeDamage(int dmg){
        currHP -= dmg;
    }

    public void DelayDamage(){
        myBC.enabled=false;
            gameObject.SetActive(false);
            gameObject.SetActive(true);
        
        Invoke("EnableDamage", 0.1f);
       

    }

    public void EnableDamage(){
        myBC.enabled=true;
    }

    private void OnCollisionEnter2D(Collision2D collision){

        //Destroys the gameObject upon colliding with a box collider of some sort
        if(collision.gameObject.name == "bullet(Clone)"){
            TakeDamage(2);
            DelayDamage();
        }

        if(collision.gameObject.name == "Player"){
            gameObject.SetActive(false);
            gameObject.SetActive(true);
        }

        if(collision.gameObject.tag == "dp"){
            Destroy(gameObject);
        }
    }

    void Start()
    {
        currHP = maxHP;
        myBC = gameObject.GetComponent<BoxCollider2D>();
        Score = GameObject.Find("Score");
        Sound = GameObject.Find("SFX");
    }

    void Update()
    {

        if(currHP <= 0){
            //Can put point in here
            switch(gameObject.name){
                case "Enemy":
                    //print("Ouch");
                    Score.GetComponent<score>().pts += 200;
                    Sound.GetComponent<sfwScript>().playEded();
                    break;
                case "Tank":
                    //print("YOUCH!");
                    Score.GetComponent<score>().pts += 500;
                    Sound.GetComponent<sfwScript>().playEded();
                    break;
                case "Speed":
                    //print("AGH IM DYING");
                    Score.GetComponent<score>().pts += 100;
                    Sound.GetComponent<sfwScript>().playEded();
                    break;

                case "Enemy(Clone)":
                    //print("Ouch");
                    Score.GetComponent<score>().pts += 200;
                    Sound.GetComponent<sfwScript>().playEded();
                    break;
                case "Tank(Clone)":
                    //print("YOUCH!");
                    Score.GetComponent<score>().pts += 500;
                    Sound.GetComponent<sfwScript>().playEded();
                    break;
                case "Speed(Clone)":
                    //print("AGH IM DYING");
                    Score.GetComponent<score>().pts += 100;
                    Sound.GetComponent<sfwScript>().playEded();
                    break;
            }

            Destroy(gameObject);
        }
    }
}
