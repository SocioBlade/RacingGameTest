using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class O_powerUp : MonoBehaviour
{
    public GameObject pickupEffect;

    public float multiplier = 3f;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            Pickup(other);
        }
    }

    void Pickup(Collider player)
    {
        //Spawn Cool Effect
        Instantiate(pickupEffect, transform.position, transform.rotation);

        //Apply effect to the player
        bMoveScript speed = player.GetComponent<bMoveScript>();

        speed.moveSpeed *= multiplier;

        //Remove power up object
        Destroy(gameObject);

    }
}
