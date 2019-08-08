using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exitscript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Application.Quit();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Application.Quit();
        }
    }
}
