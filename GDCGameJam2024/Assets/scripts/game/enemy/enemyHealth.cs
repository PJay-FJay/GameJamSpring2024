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
    }

    void Start()
    {
        currHP = maxHP;
        myBC = gameObject.GetComponent<BoxCollider2D>();
        Score = GameObject.Find("Score");
    }

    void Update()
    {

        if(currHP <= 0){
            //Can put point in here
            switch(gameObject.name){
                case "Enemy":
                    print("Ouch");
                    Score.GetComponent<score>().pts += 200;
                    break;
                case "Tank":
                    print("YOUCH!");
                    Score.GetComponent<score>().pts += 500;
                    break;
                case "Speedy":
                    print("AGH IM DYING");
                    Score.GetComponent<score>().pts += 100;
                    break;
            }
            Destroy(gameObject);
        }
    }
}
