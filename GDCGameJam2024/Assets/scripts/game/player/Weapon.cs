using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    //Defining 3 variables; a game object for a prefab we will make, a transform variable for our bullet spawn point, a float for the speed of our bullet
    public GameObject bulletPrefab;
    public Transform firePt;
    public float fireForce = 20f;

    public void Fire(){

        //Initializes a bullet and then shoots that bullet from a given spawnpoint
        GameObject bullet = Instantiate(bulletPrefab, firePt.position, firePt.rotation);
        bullet.GetComponent<Rigidbody2D>().AddForce(firePt.up * fireForce, ForceMode2D.Impulse);        //The velocity of the bullet when it is shot.

        Destroy(bullet, 0.5f);

    }

}
