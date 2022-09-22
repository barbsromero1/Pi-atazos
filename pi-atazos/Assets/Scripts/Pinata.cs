using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pinata : MonoBehaviour
{
    public Transform pTail;
    public Transform pHead;
    public Vector3 move;
    public Vector3 move2;

    void OnTriggerEnter(Collider other)
    {
        pTail.position += move;
        pHead.position += move2;
    }
}
