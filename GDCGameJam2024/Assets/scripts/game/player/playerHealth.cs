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

    //Function for taking damage and updating the health bar when needed with any given value
    void TakeDamage(int dmg){
        currHP -= dmg;
        healthBar.setHealth(currHP);
    }

    private void DelayDamage(){
        myBC.enabled=false;
            gameObject.SetActive(false);
            gameObject.SetActive(true);
        
        Invoke("EnableDamage", 0.1f);
       

    }

    private void OnCollisionEnter2D(Collision2D collision){

        //Destroys the gameObject upon colliding with a box collider of some sort
        if(collision.gameObject.name == "enemy(close)" || collision.gameObject.name == "enemy"){
            TakeDamage(2);
            DelayDamage();
        }
    }

    // Start is called before the first frame update
    void Start(){
        currHP = maxHP;
        healthBar.setMaxHealth(maxHP);
    }

    // Update is called once per frame
    void Update(){
        //For now temporarily set a key to test the health
        if(Input.GetKeyDown(KeyCode.Tab)){
            TakeDamage(3);
        }
    }

    
}
