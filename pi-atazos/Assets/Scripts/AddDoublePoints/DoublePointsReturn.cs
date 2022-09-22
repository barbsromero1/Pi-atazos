using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoublePointsReturn : PinataReturn
{
    private ObjPoolingDoublePoints objectPoolDoublePoints;

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
}
