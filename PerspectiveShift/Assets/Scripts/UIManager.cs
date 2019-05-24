using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    #region Variables
    //Singleton pattern
    public static UIManager Instance;

    [SerializeField] GameObject mainCanvas;
    [SerializeField] GameObject instructCanvas;
    #endregion

    #region Unity API FUnctions
    private void Awake()
    {
        //Singleton pattern
        if (Instance != null && Instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(this);
        }
    }
    private void Start()
    {
        //On start of the application
        ShowMainCanvas();
    }
    #endregion

    #region Button Press Functions
    public void StartInstructions()
    {
        ShowInstructCanvas();
    }
    #endregion

    #region Helper Functions
    private void ShowMainCanvas()
    {
        mainCanvas.SetActive(true);
        instructCanvas.SetActive(false);
    }

    private void ShowInstructCanvas()
    {
        mainCanvas.SetActive(false);
        instructCanvas.SetActive(true);
    }
    #endregion
}
