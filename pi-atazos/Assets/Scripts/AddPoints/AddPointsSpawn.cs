using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddPointsSpawn : MonoBehaviour
{
    private float timeToSpawn = 1f;
    private float timeSinceSpawn = 0;
    private ObjPoolAddPoints objectPool;

    public bool pause;
    public bool gameOver;
    public CanvasManager canvasM;

    public Vector3 center;
    public Vector3 size;

    private void Awake()
    {
        FindPools();
        pause = canvasM.GameIsPaused;
        gameOver = canvasM.GameIsPaused;
    }

    void Update()
    {
        if (!pause || !gameOver)
        {
            timeSinceSpawn += Time.deltaTime;
            if (timeSinceSpawn >= timeToSpawn)
            {
                //random posición de spawn 
                Vector3 pos = center + new Vector3(-1.8f, 8, Random.Range(-size.z, size.z));
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
