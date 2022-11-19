using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PinReset : MonoBehaviour
{

    public List<Vector3> m_startingPos;
    public List<Quaternion> m_startingRot;

    public int TotalScore = 0;

    // public List<Vector3> m_newPos;
    // public List<Quaternion> m_newRot;

    // Start is called before the first frame update
    void Start()
    {
        var pins = GameObject.FindGameObjectsWithTag("Pin"); // Identifying every game oject with the 'Pin' tag attached
        m_startingPos = new List<Vector3>(); // Initializing a new list of pin positions for each one of the aforementioned pin tag objects
        m_startingRot = new List<Quaternion>(); // Initializing a new list of pin rotations for the same objects as above

        foreach (var pin in pins) // Scanning through each pin and adding their position and rotation values to respective lists
        {
            m_startingPos.Add(pin.transform.position);
            m_startingRot.Add(pin.transform.rotation);
        }

        // m_newPos = new List<Vector3>(); // Preparing Lists for Positions and Rotations that will be constantly updating
        // m_newRot = new List<Quaternion>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W)) // Starting the Coroutine to Check Any Changes in Pin Positions after ball is thrown
        {
            // StartCoroutine(CheckPins());
        }
        
        if (Input.GetKeyDown(KeyCode.Space)) // Resetting all pins to their original positions
        {
            var pins = GameObject.FindGameObjectsWithTag("Pin");
            var i = 0; // Index Counter Variable

            foreach (var pin in pins) // VELOCITY & ANGULAR VELOCITY STILL MOVING PINS!!!!
            {
                pin.transform.position = m_startingPos[i];
                pin.transform.rotation = m_startingRot[i];

                pin.GetComponent<Rigidbody>().velocity = Vector3.zero;
                pin.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;

                i += 1;
            }
        }
    }
}

    //IEnumerator CheckPins()
    //{
    //    var pins = GameObject.FindGameObjectsWithTag("Pin"); // Identifying every game oject with the 'Pin' tag attached
    //    var i = 0; // Index Counter Variable

    //    foreach (var new_pos in m_newPos)
    //    {
    //        Debug.Log("Comparing...");
    //        if (new_pos != m_startingPos[i]) // For each new pin position, if it doesn't equal it's old position, increase score by 1 & move onto next pin to check
    //        {
    //            Debug.Log("+1 Score");

    //            TotalScore += 1;
    //            i += 1;
    //        }
    //        else
    //        {
    //            Debug.Log("0 Score");

    //            i += 1;
    //        }
    //    }

    //    foreach (var pin in pins)
    //    {
    //        Debug.Log("Adding New Pos/Rot Pins");
    //        m_newPos.Add(pin.transform.position); // Every x seconds, add new pin positions to new pin list
    //        m_newRot.Add(pin.transform.rotation); // Every x seconds, add new pin rotations to new rotation list

    //        Debug.Log("Waiting");
    //        yield return new WaitForSeconds(4);
    //    }

    //    Debug.Log("Clearing...");
    //    m_newPos.Clear();
    //    m_newRot.Clear();

    //    Debug.Log("Waiting...");
    //    yield return new WaitForSeconds(4);

    //    // yield return null;
    //}



