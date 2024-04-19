using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    
    private void OnCollisionEnter2D(Collision2D collision){

        //Destroys the gameObject upon colliding with a box collider of some sort
        Destroy(gameObject, 0.01f);

    }

}
