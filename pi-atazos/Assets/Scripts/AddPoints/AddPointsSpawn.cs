using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddPointsSpawn : MonoBehaviour
{
    private float timeToSpawn = 0.8f;
    private float timeSinceSpawn = 0;
    private ObjPoolAddPoints objectPool;

    public bool pause;
    public CanvasManager canvasM;

    public Vector3 center;
    public Vector3 size;

    private void Awake()
    {
        FindPools();
        pause = canvasM.GameIsPaused;
    }

    void Update()
    {
        if (!pause)
        {
            timeSinceSpawn += Time.deltaTime;
            if (timeSinceSpawn >= timeToSpawn)
            {
                //random posición de spawn 
                Vector3 pos = center + new Vector3(-0.5f, 5, Random.Range(-size.z, size.z));
                //sacar piñata del queu
                GameObject newPinata = objectPool.GetPinata();
                //nueva posición en la cual saldra
                newPinata.transform.position = pos;
                timeSinceSpawn = 0f;
            }
        }
    }

    virtual public void FindPools()
    {
        objectPool = FindObjectOfType<ObjPoolAddPoints>();
    }
}
