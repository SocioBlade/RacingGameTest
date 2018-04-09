using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class O_powerUp : MonoBehaviour
{
    public GameObject pickupEffect;
    public float duration = 4f;
    private GameObject clone;

    public float multiplier = 3f;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            StartCoroutine( Pickup(other) );
        }
    }

    IEnumerator Pickup(Collider player)
    {
        //Spawn Cool Effect
        clone = Instantiate(pickupEffect, transform.position, transform.rotation);

        //Waiting allows for the powerUp object to still be visible. This removes it.

        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<Collider>().enabled = false;

        //pickupEffect.transform.SetParent(gameObject.transform);

        //Apply effect to the player
        bMoveScript speed = player.GetComponent<bMoveScript>();

        speed.moveSpeed *= multiplier;

        //wait x amount of seconds

        yield return new WaitForSeconds(1f);

        //Stops the particleSystem from repeating itself during the duration. 
        //Must be placed after small delay as putting it higher destroys the system before it is seen.
        clone.GetComponent<ParticleSystem>().Stop();

        yield return new WaitForSeconds(duration-1);


        //reverse effect on our player

        speed.moveSpeed /= multiplier;

        //Remove power up object
        Destroy(clone);
        Destroy(gameObject);

    }
}
