using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PinataReturn : MonoBehaviour
{
    private ObjectPool objectPool;
    
    // Start is called before the first frame update
    void Start()
    {
        FindPools();
    }

    virtual public void OnDisablePinata()
    {
        if (objectPool != null)
        {
            objectPool.ReturnPinata(this.gameObject);
            Debug.Log("ondisable");
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        Debug.Log("ORIGINAL on Collision");
        //if (collision.collider.gameObject.layer == LayerMask.NameToLayer("Ground"))
        //{
        //    Debug.Log("Return");
        //    OnDisablePinata();
        //}
        if (collision.gameObject.tag == "Bat")
        {
            PinataOnAccion();
        }
    }

    virtual public void FindPools()
    {
        objectPool = FindObjectOfType<ObjectPool>();
    }

    virtual public void PinataOnAccion()
    {
        //piñata hace GameOver
    }
}
