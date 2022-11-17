using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{

    [SerializeField] private float m_lateralVelocity = 0.25f;
    [SerializeField] private Vector3 m_pos;
    [SerializeField] private Vector3 m_startingPos = new Vector3(11.35f, 0.1f, 37.8f);

    [SerializeField] private Vector3 m_rightBarrier;
    [SerializeField] private Vector3 m_leftBarrier;


    // Start is called before the first frame update
    void Start()
    {
        m_rightBarrier = new Vector3(10.9f, 0.1f, 37.8f);
        m_leftBarrier = new Vector3(11.75f, 0.1f, 37.8f);
    }

    // Update is called once per frame
    void Update()
    {
        m_pos = transform.position;

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.left * m_lateralVelocity * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.right * m_lateralVelocity * Time.deltaTime);
        }

        //if (m_pos.x <= m_rightBarrier.x)
        //{
        //    m_firstDirection = false;
        //}

        //if (m_pos.x >= m_leftBarrier.x)
        //{
        //    m_firstDirection = true;
        //}

        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.position = m_startingPos;
        }
    }
}

