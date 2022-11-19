using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideArrow : MonoBehaviour
{
    public GameObject AimArrow;
    public MeshRenderer rend;

    // Start is called before the first frame update
    void Start()
    {
        AimArrow = GameObject.FindWithTag("Arrow");
        rend = AimArrow.GetComponent<MeshRenderer>();
        rend.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W)) // Disabling Mesh Renderer to hide Aim Arrow after shooting ball
        {
            rend.enabled = false;
        }

        if (Input.GetKeyDown(KeyCode.Space)) // Re-enabling Mesh Renderer to show Aim Arrow after resetting ball
        {
            rend.enabled = true;
        }
    }
}
