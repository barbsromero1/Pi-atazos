using System.Collections;
using System.Collections.Generic;
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

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.layer == LayerMask.NameToLayer("Ground"))
        {
            Debug.Log("Return");
            OnDisablePinata();
        }
    }

    virtual public void FindPools()
    {
        objectPool = FindObjectOfType<ObjectPool>();
    }
}
