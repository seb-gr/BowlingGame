using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject Ball;

    // Start is called before the first frame update
    void Start()
    {
        Ball = GameObject.FindWithTag("Ball");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = Ball.transform.position;
        transform.position = pos;
    }
}
