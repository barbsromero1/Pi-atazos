using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

public class piñatasFall : MonoBehaviour
{
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(1, 5, 1);
    }

    private void OnEnable()
    {
        rb.velocity = new Vector3(1, 5, 1);
    }
}
