using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TripplePointsSpawner : MonoBehaviour
{
    private float timeToSpawn = 1.6f;
    private float timeSinceSpawn;
    private ObjPoolTripplePoints objectPool;

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
                //random posici�n de spawn 
                Vector3 pos = center + new Vector3(-1.8f, 8, Random.Range(-size.z, size.z));
                //sacar pi�ata del queu
                GameObject newPinata = objectPool.GetPinata();
                //nueva posici�n en la cual saldra
                newPinata.transform.position = pos;
                timeSinceSpawn = 0f;
            }
        }
    }

    virtual public void FindPools()
    {
        objectPool = FindObjectOfType<ObjPoolTripplePoints>();
    }
}
