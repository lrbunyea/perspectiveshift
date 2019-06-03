using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerController : MonoBehaviour
{
    #region Variables
    [SerializeField] Text timerText;

    private int minutes;
    private float seconds;

    private bool isCounting;
    #endregion

    #region Unity API Functions
    void Start()
    {
        minutes = 2;
        seconds = 0;
        isCounting = false;
    }
    
    void Update()
    {
        if (isCounting)
        {
            seconds -= Time.deltaTime;
            if (seconds - Time.deltaTime < 0)
            {
                if (minutes == 0)
                {
                    isCounting = false;
                    //next screen
                }
                else
                {
                    seconds = 59;
                    minutes--;
                    timerText.text = "You have " + minutes + ":" + Mathf.Round(seconds) + " left to draw the structure.";
                }
            } else
            {
                timerText.text = "You have " + minutes + ":" + Mathf.Round(seconds) + " left to draw the structure.";
            }
        }
    }
    #endregion

    #region Helper Functions
    public void StartTimer()
    {
        isCounting = true;
    }
    #endregion
}
