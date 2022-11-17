using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimRotation : MonoBehaviour
{
    [SerializeField] private float m_aimRotationSpeed = 25.0f;

    // Update is called once per frame
    void Update()
    {
        transform.localEulerAngles = new Vector3(0, Mathf.PingPong(Time.time * m_aimRotationSpeed, 50) - 25, 0);
    }
}
