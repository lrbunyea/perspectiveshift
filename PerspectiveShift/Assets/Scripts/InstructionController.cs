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
        instructText.text = instructions[instructCnt];
    }
    #endregion

    #region Text Display Functions
    public void SetNextInsruct()
    {
        if (instructCnt < totInstruct)
        {
            instructCnt++;
            instructText.text = instructions[instructCnt];
        }
    }

    public void SetPreviousInsruct()
    {
        if (instructCnt > 0)
        {
            instructCnt--;
            instructText.text = instructions[instructCnt];
            
        }
    }
    #endregion

    #region Helper Functions
    private void InitializeInstructions()
    {
       instructions = new string[] 
            {"Put the game board on a play surface that is comfortably accessible to all players.",
            "Seat players around the board at the four indication symbols.",
            "All players pick a constant position to sit, this is the only position that you are allowed to consider the game board from.",
            "Place the structural materials in a location where they are accessible to every player."};
        instructCnt = 0;
        totInstruct = instructions.Length;
    }
    #endregion
}
