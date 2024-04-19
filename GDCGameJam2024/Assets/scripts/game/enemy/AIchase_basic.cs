using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIchase_basic : MonoBehaviour
{

    private float distance;
    public GameObject player;
    public float speed;

    void Update()
    {
        player = GameObject.Find("Player");

        //Gets distance from player to the enemy
        distance = Vector2.Distance(transform.position, player.transform.position);
        Vector2 direction = player.transform.position - transform.position;

        //setting up rotating the Enemy
        direction.Normalize();     
            //Atan2 Finds angle between two points > Rad2Deg converts radians to degrees || Atan2 returns the angle in radians**
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        //updates the current position of the enemy based on the distance from the player and moving them in a given frame of time
        transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, speed * Time.deltaTime);

        //updates the rotation of the enemy, allowing for the enemy to face the place upon giving chase
        transform.rotation = Quaternion.Euler(Vector3.forward * angle);
    }
}
