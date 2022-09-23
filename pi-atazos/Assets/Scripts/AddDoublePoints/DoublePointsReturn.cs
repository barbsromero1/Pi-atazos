using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoublePointsReturn : PinataReturn
{
    private ObjPoolingDoublePoints objectPoolDoublePoints;
    private int contColl = 0;
    private int points = 2;

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

    override public void PinataOnAccion()
    {
        //If the GameObject has the same tag as specified, output this message in the console
        Debug.Log("BAT Double");
        contColl += 1;
        if (contColl == 2)
        {
            OnDisablePinata();
            //agregar puntos dobles
            Score.AddScore(points);
            //Regresar el contador a 0 
            contColl = 0;
        }
    }
}
