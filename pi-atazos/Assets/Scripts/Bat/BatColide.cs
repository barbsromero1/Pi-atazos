using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatColide : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        //Check for a match with the specific tag on any GameObject that collides with your GameObject
        if (collision.gameObject.layer == LayerMask.NameToLayer("Ground"))
        {
            //If the GameObject has the same tag as specified, output this message in the console
            Debug.Log("Tagggg GameOver");

        }

    }
}
