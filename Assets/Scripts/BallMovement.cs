using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{

    public GameObject Arrow;
    [SerializeField] private float m_aimDir;
    
    [SerializeField] private float m_lateralVelocity = 0.25f; // Initializing Side-to-Side Speed
    [SerializeField] private float m_bowlVelocity = -2500.0f; // Initializing bowl force
    [SerializeField] private Vector3 m_pos;
    [SerializeField] private Vector3 m_startingPos = new Vector3(11.35f, 0.1f, 37.8f);

    [SerializeField] private Vector3 m_rightBarrier;
    [SerializeField] private Vector3 m_leftBarrier;

    private Rigidbody rb;

    void Start()
    {
        m_rightBarrier = new Vector3(10.9f, 0.1f, 37.8f); // Assigning right & left starting lane barriers
        m_leftBarrier = new Vector3(11.75f, 0.1f, 37.8f);

        rb = GetComponent<Rigidbody>(); // Detecting Rigidbody to apply force later
        rb.detectCollisions = true;

        Arrow = GameObject.FindWithTag("PivotPoint"); // Grabbing the Pivot Point Game Object for Aim Direction Calculation
    }

    void Update()
    {
        m_pos = transform.position; // Calculating Position of Bowling Ball
        m_aimDir = Arrow.transform.rotation.y; // Tracking the Y Rotation Angle of the Arrow

        if (Input.GetKey(KeyCode.D) && m_pos.x >= m_rightBarrier.x) // Move Ball Right on Lane
        {
            transform.Translate(Vector3.left * m_lateralVelocity * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A) && m_pos.x <= m_leftBarrier.x) // Move Ball Left on Lane
        {
            transform.Translate(Vector3.right * m_lateralVelocity * Time.deltaTime);
        }

        if (Input.GetKeyUp(KeyCode.W)) // Shooting the Ball With Force Vectors
        {
            rb.AddForce(new Vector3((m_aimDir *  m_bowlVelocity), 0, m_bowlVelocity));
        }

        if (Input.GetKeyDown(KeyCode.Space)) // Ball Reset
        {
            transform.position = m_startingPos;
            transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
            rb.velocity = new Vector3(0, 0, 0);
            rb.angularVelocity = new Vector3(0, 0, 0);
        }
    }
}

