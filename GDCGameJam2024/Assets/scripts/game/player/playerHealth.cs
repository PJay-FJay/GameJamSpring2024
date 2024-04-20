using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerHealth : MonoBehaviour
{
    //basic int variables for calculating health
    public int maxHP = 15;
    public int currHP;
    
    //reference to health bar
    public healthBar healthBar;
    private BoxCollider2D myBC;

    //
    public GameObject Sound;
    

    //Function for taking damage and updating the health bar when needed with any given value
    void TakeDamage(int dmg){
        currHP -= dmg;
        Sound.GetComponent<sfwScript>().playPhurt();
        healthBar.setHealth(currHP);
    }

    private void DelayDamage(){
        myBC.enabled=false;
        Invoke("EnableDamage", 1f);
    }

    private void EnableDamage(){
        myBC.enabled=true;
    }

    private void OnCollisionEnter2D(Collision2D collision){

        //Destroys the gameObject upon colliding with a box collider of some sort
        if(collision.gameObject.tag == "enemy"){
            
            switch(collision.gameObject.name){
                case "Tank":
                    print("TANK!");
                    TakeDamage(5);
                    DelayDamage();
                    break;
                
                case "Tank(Clone)":
                    print("TANK!");
                    TakeDamage(5);
                    DelayDamage();
                    break;

                case "Enemy":
                    print("UWU");
                    TakeDamage(2);
                    DelayDamage();
                    break;

                case "Enemy(Clone)":
                    print("UWU");
                    TakeDamage(2);
                    DelayDamage();
                    break;

                case "Speed(Clone)":
                    print("OWO");
                    TakeDamage(2);
                    DelayDamage();
                    break;

                case "Speed":
                    print("OWO");
                    TakeDamage(1);
                    DelayDamage();
                    break;
            }

            
        }
    }

    // Start is called before the first frame update
    void Start(){
        currHP = maxHP;
        healthBar.setMaxHealth(maxHP);
        myBC = gameObject.GetComponent<BoxCollider2D>();
        Sound = GameObject.Find("SFX");
    }

    // Update is called once per frame
    void Update(){
        //For now temporarily set a key to test the health
        /*if(Input.GetKeyDown(KeyCode.Tab)){
            TakeDamage(3);
        }*/

        if(currHP <= 0){
            gameObject.SetActive(false);
            print("Game Over");

        }

    }

    
}
