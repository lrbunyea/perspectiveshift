using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TopicController : MonoBehaviour
{
    #region Variables
    [SerializeField] Text topicText;
    [SerializeField] GameObject topicButton;
    [SerializeField] GameObject nextButton;

    private string[] topics;
    private int numTopics;
    private int curIndex;
    #endregion

    #region Unity API Functions
    void Start()
    {
        InitializeTopicList();
    }
    #endregion

    #region Helper Functions
    private void InitializeTopicList()
    {
        topics = new string[] 
        {"Topic1",
        "Topic2",
        "Topic3",
        "Topic4",
        "Topic5"
        };
        numTopics = topics.Length;
        curIndex = 0;
    }

    public void GenerateTopic()
    {
        curIndex = Random.Range(0, numTopics);
        UIManager.Instance.currentTopic = topics[curIndex];
        topicButton.SetActive(false);
        nextButton.SetActive(true);
        topicText.text = "Your discussion topic is " + UIManager.Instance.currentTopic;
    }

    public void NextScreen()
    {
        UIManager.Instance.ShowTimerCanvas();
    }
    #endregion
}
