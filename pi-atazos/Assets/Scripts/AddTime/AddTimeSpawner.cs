using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddTimeSpawner : MonoBehaviour
{
    private float timeToSpawn = 3f;
    private float timeSinceSpawn;
    private ObjPoolAddTime objectPool;

    public TimeManager TimeManager;
    private float totalTime;
    private float lastSeconds = 30;

    public bool pause;
    public CanvasManager canvasM;

    public Vector3 center;
    public Vector3 size;

    private void Awake()
    {
        FindPools();
        pause = canvasM.GameIsPaused;
    }

    private void Start()
    {
        totalTime = TimeManager.GetComponent<TimeManager>().timeRemaining;
    }

    // Update is called once per frame
    void Update()
    {
        if (!pause)
        {
            timeSinceSpawn += Time.deltaTime;
            totalTime -= Time.deltaTime;
            if (totalTime <= lastSeconds)
            {
                Debug.Log("Time 30s");
                //que tan frecuente se lanza cada piñata
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
    }

    virtual public void FindPools()
    {
        objectPool = FindObjectOfType<ObjPoolAddTime>();
    }
}
