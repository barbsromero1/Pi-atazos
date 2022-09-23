using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TripplePointsSpawner : MonoBehaviour
{
    public float timeToSpawn = 1f;
    private float timeSinceSpawn;
    private ObjPoolTripplePoints objectPool;

    public Vector3 center;
    public Vector3 size;

    private void Awake()
    {
        FindPools();
    } 

    void Update()
    {
        timeSinceSpawn += Time.deltaTime;
        if (timeSinceSpawn >= timeToSpawn)
        {
            //random posición de spawn 
            Vector3 pos = center + new Vector3(1, 10, Random.Range(-size.z, size.z));
            //sacar piñata del queu
            GameObject newPinata = objectPool.GetPinata();
            //nueva posición en la cual saldra
            newPinata.transform.position = pos;
            timeSinceSpawn = 0f;
        }
        if (Time.deltaTime == 40f)//o puntajje o algo del estilo para aumentar difuciltad 
        {
            //timeToSpawn = 0.1f;
        }
    }

    virtual public void FindPools()
    {
        objectPool = FindObjectOfType<ObjPoolTripplePoints>();
    }
}
