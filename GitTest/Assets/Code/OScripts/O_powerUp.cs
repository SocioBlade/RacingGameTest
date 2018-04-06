using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class O_powerUp : MonoBehaviour
{
    public GameObject pickupEffect;

    public float multiplier = 1.4f;

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
        player.transform.localScale *= multiplier;

        //Remove power up object
        Destroy(gameObject);

    }
}
