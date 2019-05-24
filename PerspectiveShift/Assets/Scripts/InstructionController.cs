using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InstructionController : MonoBehaviour
{
    #region Variables
    [SerializeField] Text instructText;
    private int instructCnt;
    private int totInstruct;
    private string[] instructions;
    #endregion

    #region Unity API Functions
    void Start()
    {
        InitializeInstructions();
        SetNextInsruct();
    }
    #endregion

    #region Text Display Functions
    public void SetNextInsruct()
    {
        if (instructCnt < totInstruct)
        {
            instructText.text = instructions[instructCnt];
            instructCnt++;
        }
    }
    #endregion

    #region Helper Functions
    private void InitializeInstructions()
    {
       instructions = new string[] 
            {"Hey",
            "Does",
            "this work?"};
        instructCnt = 0;
        totInstruct = instructions.Length;
    }
    #endregion
}
