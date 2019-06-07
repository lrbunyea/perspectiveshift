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
    [SerializeField] GameObject introCanvas;
    [SerializeField] GameObject versionCanvas;
    [SerializeField] GameObject instructCanvas;
    [SerializeField] GameObject topicCanvas;
    [SerializeField] GameObject timerCanvas;

    //data variable
    public Version currentVersion;
    public DialogueState currentDialogueState;
    public string currentTopic = "";

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
        Introduction,
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
    }
    #endregion

    #region Button Press Functions
    public void StartIntroduction()
    {
        ShowIntroCanvas();
    }

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
        introCanvas.SetActive(false);
        versionCanvas.SetActive(false);
        instructCanvas.SetActive(false);
        topicCanvas.SetActive(false);
        timerCanvas.SetActive(false);
        currentDialogueState = DialogueState.Start;
    }

    private void ShowIntroCanvas()
    {
        mainCanvas.SetActive(false);
        introCanvas.SetActive(true);
        versionCanvas.SetActive(false);
        instructCanvas.SetActive(false);
        topicCanvas.SetActive(false);
        timerCanvas.SetActive(false);
        currentDialogueState = DialogueState.Introduction;
    }

    private void ShowVersionCanvas()
    {
        mainCanvas.SetActive(false);
        introCanvas.SetActive(false);
        versionCanvas.SetActive(true);
        instructCanvas.SetActive(false);
        topicCanvas.SetActive(false);
        timerCanvas.SetActive(false);
        currentDialogueState = DialogueState.VSelect;
    }

    public void ShowInstructCanvas()
    {
        mainCanvas.SetActive(false);
        introCanvas.SetActive(false);
        versionCanvas.SetActive(false);
        instructCanvas.SetActive(true);
        topicCanvas.SetActive(false);
        timerCanvas.SetActive(false);
    }

    public void ShowTopicCanvas()
    {
        mainCanvas.SetActive(false);
        introCanvas.SetActive(false);
        versionCanvas.SetActive(false);
        instructCanvas.SetActive(false);
        topicCanvas.SetActive(true);
        timerCanvas.SetActive(false);
        currentDialogueState = DialogueState.TSelect;
    }

    public void ShowTimerCanvas()
    {
        mainCanvas.SetActive(false);
        introCanvas.SetActive(false);
        versionCanvas.SetActive(false);
        instructCanvas.SetActive(false);
        topicCanvas.SetActive(false);
        timerCanvas.SetActive(true);
        currentDialogueState = DialogueState.DrawTimer;
    }
    #endregion
}
