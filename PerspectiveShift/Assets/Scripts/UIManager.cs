using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    #region Variables
    //Singleton pattern
    public static UIManager Instance;

    //references
    [SerializeField] GameObject mainCanvas;
    [SerializeField] GameObject versionCanvas;
    [SerializeField] GameObject instructCanvas;

    //data variable
    public Version currentVersion;
    public DialogueState currentDialogueState;

    //Application states
    public enum Version
    {
        Version1,
        Version2,
        Version3
    };

    public enum DialogueState
    {
        Start,
        VSelect,
        Setup,
        TSelect,
        TurnInstruct,
        DrawTimer,
        CaptionInstruct,
        Camera,
        Upload
    };
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
        currentDialogueState = DialogueState.Start;
    }
    #endregion

    #region Button Press Functions
    public void StartVersionSelect()
    {
        ShowVersionCanvas();
    }

    public void StartInstructions()
    {
        ShowInstructCanvas();
    }
    #endregion

    #region Helper Functions
    private void ShowMainCanvas()
    {
        mainCanvas.SetActive(true);
        versionCanvas.SetActive(false);
        instructCanvas.SetActive(false);
    }

    private void ShowVersionCanvas()
    {
        mainCanvas.SetActive(false);
        versionCanvas.SetActive(true);
        instructCanvas.SetActive(false);
    }

    private void ShowInstructCanvas()
    {
        mainCanvas.SetActive(false);
        versionCanvas.SetActive(false);
        instructCanvas.SetActive(true);
    }
    #endregion
}
