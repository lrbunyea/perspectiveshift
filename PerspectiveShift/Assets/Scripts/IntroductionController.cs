using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IntroductionController : MonoBehaviour
{
    #region Variables
    [SerializeField] Text introductionText;
    [SerializeField] GameObject introductionCanvas;
    [SerializeField] int textOffset;
    [SerializeField] float lastY;
    [SerializeField] GameObject lastObject;

    private int introCnt;
    private int totIntroCnt;
    private string[] introduction;
    #endregion

    #region Unity API Functions
    void Start()
    {
        InitializeIntroduction();
    }
    #endregion

    public void SetNextIntro()
    {
        if (introCnt < totIntroCnt - 1)
        {
            if (introCnt == 0)
            {
                lastObject = Instantiate(introductionText.gameObject, introductionText.gameObject.transform.position, Quaternion.identity);
                lastObject.GetComponent<Text>().text = introduction[introCnt];
                lastObject.transform.SetParent(introductionCanvas.transform, false);
                introCnt++;
            } else
            {
                lastY = lastObject.GetComponent<RectTransform>().localPosition.y;
                lastObject = Instantiate(introductionText.gameObject, new Vector3(introductionText.gameObject.transform.position.x, lastY - textOffset, 0), Quaternion.identity);
                lastObject.GetComponent<Text>().text = introduction[introCnt];
                lastObject.transform.SetParent(introductionCanvas.transform, false);
                
                introCnt++;
            }
        }
        else
        {
            UIManager.Instance.StartVersionSelect();
        }
    }

    private void InitializeIntroduction()
    {
        introduction = new string[]
            {"Perspective Shift is an opportunity to have a meaningful conversation disguised as a game.",
            "You will be asked to maintain this conversation while you collectively build  structure.",
            "This is a game with no losers or winners.",
            "Only new friends"};
        introCnt = 0;
        totIntroCnt = introduction.Length;
    }
}
