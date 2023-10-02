using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quiter : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) 
        {
            Debug.Log("Should quit the game");
            Application.Quit();
        }
    }
}
