using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddPointsReturn : PinataReturn
{
    private ObjPoolAddPoints objectPoolAddPoints;
    private int points = 1;
    public Score Score;

    private void Awake()
    {
        FindPools();
        Score = FindObjectOfType<Score>();
    }

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
        }
    }

    public override void PinataOnAccion()
    {
        OnDisablePinata();
        //agregar puntos dobles
        Score.AddScore(points);
        //Regresar el contador a 0 
    }
}
