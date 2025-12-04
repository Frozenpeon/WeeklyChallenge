using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public GameObject target;

    // Update is called once per frame
    void Update()
    {
        transform.position = target.transform.position + new Vector3(0, 0, -10);
    }
}
