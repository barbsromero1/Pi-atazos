using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    AudioSource audiosource;
    //private void OnTriggerEnter(Collider other)
    //{
    //    audiosource.Play();
    //}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bat")
        {
            audiosource.Play();
        }

    }
    // Start is called before the first frame update
    void Start()
    {
        audiosource = GetComponent<AudioSource>();
    }

}
