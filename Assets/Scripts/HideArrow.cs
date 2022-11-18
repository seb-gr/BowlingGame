using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideArrow : MonoBehaviour
{
    public GameObject AimArrow;
    // Start is called before the first frame update
    void Start()
    {
        AimArrow = GameObject.FindWithTag("Arrow");
        AimArrow.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            AimArrow.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            AimArrow.SetActive(true);
        }
    }
}
