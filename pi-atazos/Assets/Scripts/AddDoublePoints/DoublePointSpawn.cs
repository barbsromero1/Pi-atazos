using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoublePointSpawn : MonoBehaviour
{
    public float timeToSpawn = 0.6f;
    private float timeSinceSpawn;
    private ObjPoolingDoublePoints objectPool;

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
            Vector3 pos = center + new Vector3(0, 5, Random.Range(-size.z, size.z));
            GameObject newPinata = objectPool.GetPinata();
            //nueva posición en la cual saldra
            newPinata.transform.position = pos;
            timeSinceSpawn = 0f;
        }
    }

    virtual public void FindPools()
    {
        objectPool = FindObjectOfType<ObjPoolingDoublePoints>();
    }
}