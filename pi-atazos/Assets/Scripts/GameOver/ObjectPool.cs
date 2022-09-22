using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    [SerializeField]
    private GameObject pinataPrefabs;
    
    private Queue<GameObject> pinataPool = new Queue<GameObject> ();
    
    private int poolSrartSize = 8; 

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < poolSrartSize; i++)
        {
            GameObject pinata = Instantiate(pinataPrefabs);
            pinataPool.Enqueue(pinata);
            pinata.SetActive(false);
        }
    }

    public GameObject GetPinata()
    {
        if (pinataPool.Count > 0)
        {
            GameObject pinata = pinataPool.Dequeue();
            pinata.SetActive(true);
            return pinata;
        }
        else
        {
            GameObject pinata = Instantiate(pinataPrefabs);
            return pinata;
        }
    }

    public void ReturnPinata(GameObject pinata)
    {
        pinataPool.Enqueue(pinata);
        pinata.SetActive(false);
        Debug.Log("Queu Return"); 
    }
}
