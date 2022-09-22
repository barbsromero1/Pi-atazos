using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

public class AddTimeRetun : PinataReturn
{
    private ObjPoolAddTime objectPoolAddTime;

    public override void FindPools()
    {
        objectPoolAddTime = FindObjectOfType<ObjPoolAddTime>();
    }
    public override void OnDisablePinata()
    {
        if (objectPoolAddTime != null)
        {
            objectPoolAddTime.ReturnPinata(this.gameObject);
            Debug.Log("ondisable");
        }
    }
}
