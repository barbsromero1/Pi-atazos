using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PinataReturn : MonoBehaviour
{
    private ObjectPool objectPool;
    public Score Score;

    // Start is called before the first frame update
    void Start()
    {
        FindPools();
        Score = FindObjectOfType<Score>();
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
        //Regresen a la cola cuando toca el piso 
        if (collision.collider.gameObject.layer == LayerMask.NameToLayer("Ground"))
        {
            OnDisablePinata();
        }
        //Si hace collision con el bat que haga su parte cada piñata 
        if (collision.gameObject.tag == "Bat")
        {
            //método donde esta la acción de cada piñata 
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
        //sonido 
        //Cambiar a pantalla GameOver 
    }
}
