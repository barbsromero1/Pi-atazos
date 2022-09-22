using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoublePointSpawn : MonoBehaviour
{
    public float timeToSpawn = 1f;
    private float timeSinceSpawn;
    private ObjPoolingDoublePoints objectPool;

    public Vector3 center;
    public Vector3 size;

    // Start is called before the first frame update
    void Start()
    {
        //para encontrar la QUEU de las piñatas
        FindPools();
    }

    // Update is called once per frame
    void Update()
    {
        timeSinceSpawn += Time.deltaTime;
        if (timeSinceSpawn >= timeToSpawn)
        {
            //random posición de spawn 
            Vector3 pos = center + new Vector3(1, 10, Random.Range(-size.z, size.z));
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
        objectPool = FindObjectOfType<ObjPoolingDoublePoints>();
    }
}