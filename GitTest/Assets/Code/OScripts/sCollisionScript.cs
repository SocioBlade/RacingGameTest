using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sCollisionScript : MonoBehaviour
{
    public float hitCount = 0;
    public Material newMaterialref;
    public Material sMaterialref;
    public Renderer refRend;

    private void OnCollisionEnter(Collision collisionInfo)
    {
        Debug.Log(collisionInfo.collider.name);

        if(collisionInfo.collider.tag == "Obstacle")
        {
            hitCount++;

            if(hitCount == 1 )
            {
                refRend.material = newMaterialref;
            }
            else if (hitCount == 2)
            {
                refRend.material = sMaterialref;
            }
            else if (hitCount == 3)
            {
                Destroy(gameObject);
            }
        }
    }

}
