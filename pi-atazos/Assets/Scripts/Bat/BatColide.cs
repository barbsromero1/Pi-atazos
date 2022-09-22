using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatColide : MonoBehaviour
{
    private int points = 1;
    [SerializeField] 
    private Score Score;

    private void OnCollisionEnter(Collision collision)
    {
        //Check for a match with the specific tag on any GameObject that collides with your GameObject
        if (collision.gameObject.tag == "GameOver")
        {
            //If the GameObject has the same tag as specified, output this message in the console
            Debug.Log("Tagggg GameOver");

        }
        if (collision.gameObject.tag == "AddPoints")
        {
            //If the GameObject has the same tag as specified, output this message in the console
            Debug.Log("Tagggg AddPoints");
            //agregar puntos dobles
            Score.AddScore(points);
        }
        if (collision.gameObject.tag == "AddDoublePoints")
        {
            //If the GameObject has the same tag as specified, output this message in the console
            Debug.Log("Tagggg AddDoublePoints");
            points = 2; 
            //agregar puntos dobles
            Score.AddScore(points);
        }
        if (collision.gameObject.tag == "AddTriplePoints")
        {
            //If the GameObject has the same tag as specified, output this message in the console
            Debug.Log("Tagggg AddDoublePoints");
            points = 3;
            //agregar puntos dobles
            Score.AddScore(points);
        }
        if (collision.gameObject.tag == "AddTime")
        {
            //If the GameObject has the same tag as specified, output this message in the console
            Debug.Log("Tagggg AddTime");
        }

    }
}
