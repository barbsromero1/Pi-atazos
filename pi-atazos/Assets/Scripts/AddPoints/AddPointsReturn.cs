using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddPointsReturn : PinataReturn
{
    private ObjPoolAddPoints objectPoolAddPoints;

    //find de queu on start but their own pool 
    public override void FindPools()
    {
        objectPoolAddPoints = FindObjectOfType<ObjPoolAddPoints>();
    }
    //desactiva el objeto
    public override void OnDisablePinata()
    {
        if (objectPoolAddPoints != null)
        {
            objectPoolAddPoints.ReturnPinata(this.gameObject);
            Debug.Log("ondisable");
        }
    }
}
