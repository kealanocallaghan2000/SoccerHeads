using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Head : MonoBehaviour
{
    public Transform mHeadMesh;

    // Update is called once per frame
    void Update()
    {
        mHeadMesh.position = Vector3.Lerp(mHeadMesh.position, transform.position, Time.deltaTime * 30.0f);
    }

}
