using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimeManager : MonoBehaviour
{
    public float InitialDuration = 60f;
    public float CurrentTime = 0;

    private bool timesUp = false;

    // Start is called before the first frame update
    void Start()
    {
        CurrentTime = InitialDuration;
    }

    // Update is called once per frame
    void Update()
    {
        //Game Over, Should stop the game
        if (CurrentTime <= 0 && !timesUp) 
        {
            Debug.Log("Times Up");
            timesUp = true;
            SceneManager.LoadScene("EndScene");
        }

        CurrentTime -= Time.deltaTime;
    }
}
