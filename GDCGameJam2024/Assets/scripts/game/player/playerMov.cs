using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMov : MonoBehaviour
{
    
    //Defining a float variable so we could set up our movement and we set up a Rigidbody2D so we could start interacting with the player
    public Rigidbody2D rd;
    public float ms = 5f;   //Movement Speed

    //Assignment of the weapon to the player
    public Weapon weapon;

    //Two vector2 vars that will determine how the player moves and the position of the mouse on the camera.
    Vector2 move;
    Vector2 mousePos;

    //Is called upon the program being active (Like start())                                                                                //We do a lil tomfoolery here
    private void Awake(){

        //From here we get the component from Unity || This will tell our script "HEY HERES THE THING YOU NEEDED FROM THE STORE!!!!"
        rd = GetComponent<Rigidbody2D>();

    }
    
    // Update is called once per frame
    void Update(){
        
        //Input will go here || Controller Input specifically
        float mX = Input.GetAxisRaw("Horizontal");
        float mY = Input.GetAxisRaw("Vertical");

        move = new Vector2(mX, mY).normalized;
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        //Firing with Mousebutton
        if(Input.GetMouseButtonDown(0)){
            
            //This calls a function in our weapon script and runs it.
            weapon.Fire();

        }

        //Game Boundaries || Ceilings
        if(transform.position.y > 5){               //Ceiling
            Vector3 temp = transform.position;
            temp.y = 5;
            transform.position = temp;
        }

        if(transform.position.y < -5){              //Floor
            Vector3 temp = transform.position;
            temp.y = -5;
            transform.position = temp;
        }

        if(transform.position.x > 8.7f){
            Vector3 temp = transform.position;
            temp.x = 8.7f;
            transform.position = temp;
        }

        if(transform.position.x < -8.7f){
            Vector3 temp = transform.position;
            temp.x = -8.7f;
            transform.position = temp;
        }
        

    }
    
    //This method is called at the frequency of physics system || Think of it like framerate in a game, things happen at a given pace
    private void FixedUpdate(){
        
        //Movement || Preferred to be active here as to avoid the game constantly updating physics. Setting it via velocity
        rd.velocity = new Vector2(move.x * ms, move.y * ms);
        
        //Rotates the player
        Vector2 aimDir = mousePos - rd.position;
        float aimAng = Mathf.Atan2(aimDir.y, aimDir.x) * Mathf.Rad2Deg - 90f;
        rd.rotation = aimAng;   //This file bit of code now defines the rotation of our player object

    }
}
