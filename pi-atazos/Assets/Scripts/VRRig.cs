using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

[System.Serializable]

public class VRMap
{
    public Transform vrTarget;
    public Transform rigTarget;
    public Vector3 trackingPositionOffset;
    public Vector3 trackingRotationOffset;

    public void Map()
    {
        rigTarget.position = vrTarget.TransformPoint(trackingPositionOffset);
        rigTarget.rotation = vrTarget.rotation * Quaternion.Euler(trackingRotationOffset);

    }
}

public class VRRig : MonoBehaviour
{
    public VRMap head;
    public VRMap leftHand;
    public VRMap rightHand;

    public Transform headConstrain;
    public Vector3 headBodyOffest;
    public float  turnSmoothness;
    // Start is called before the first frame update
    void Start()
    {
        headBodyOffest = transform.position - headConstrain.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = headConstrain.position + headBodyOffest;
        transform.forward = Vector3.Lerp(transform.forward, Vector3.ProjectOnPlane(headConstrain.up, Vector3.up).normalized, Time.deltaTime * turnSmoothness);
        head.Map();
        leftHand.Map();
        rightHand.Map();
    }
}
