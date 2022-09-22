using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoublePointsReturn : PinataReturn
{
    private ObjPoolingDoublePoints objectPoolDoublePoints;
    private int contColl = 0;

    //find de queu on start but their own pool 
    public override void FindPools()
    {
        objectPoolDoublePoints = FindObjectOfType<ObjPoolingDoublePoints>();
    }
    //desactiva el objeto
    public override void OnDisablePinata()
    {
        if (objectPoolDoublePoints != null)
        {
            objectPoolDoublePoints.ReturnPinata(this.gameObject);
            Debug.Log("ondisable");
        }
    }

    //public override void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.gameObject.tag == "Bat")
    //    {
            
    //    }
    //    //if (collision.collider.gameObject.layer == LayerMask.NameToLayer("Ground"))
    //    //{
    //    //    OnDisablePinata();
    //    //}
    //}

    public override void PinataOnAccion()
    {
        //If the GameObject has the same tag as specified, output this message in the console
        Debug.Log("BAT");
        contColl += 1;
        if (contColl == 2)
        {
            OnDisablePinata();
            //Regresar el contador a 0 
            contColl = 0;
        }
    }
}
