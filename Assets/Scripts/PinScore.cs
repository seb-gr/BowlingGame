using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PinScore : MonoBehaviour
{
    public int TotalScore = 0;

    void OnCollisionEnter(Collision collision)
    {
        TotalScore += 1;
    }
}
