using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CameraController : MonoBehaviour
{
    //public GameObject player;
    public Transform target;
    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        //transform.position = target.transform.position + new Vector3(target.transform.position.x, 26, target.transform.position.z);
        transform.position = target.position + offset;
    }
}
