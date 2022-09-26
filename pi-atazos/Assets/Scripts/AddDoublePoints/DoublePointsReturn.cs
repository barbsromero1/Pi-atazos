using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoublePointsReturn : PinataReturn
{
    private ObjPoolingDoublePoints objectPoolDoublePoints;
    private int contColl = 0;
    private int points = 2;
    public Score Score;

    private void Awake()
    {
        FindPools();
        Score = FindObjectOfType<Score>();
    }

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
        }
    }

    override public void PinataOnAccion()
    {
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
