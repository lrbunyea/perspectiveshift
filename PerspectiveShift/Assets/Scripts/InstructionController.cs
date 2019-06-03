using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InstructionController : MonoBehaviour
{
    #region Variables
    [SerializeField] Text instructText;
    private int setupInstructCnt;
    private int totSetupInstruct;
    private int playInstructCnt;
    private int totPlayInstruct;
    private string[] setupInstructions;
    private string[] playInstructions;
    #endregion

    #region Unity API Functions
    void Start()
    {
        InitializeSetupInstructions();
        instructText.text = setupInstructions[setupInstructCnt];
        UIManager.Instance.currentDialogueState = UIManager.DialogueState.Setup;
    }
    #endregion

    #region Text Display Functions
    public void SetNextInsruct()
    {
        if (UIManager.Instance.currentDialogueState == UIManager.DialogueState.Setup)
        {
            if (setupInstructCnt < totSetupInstruct-1)
            {
                setupInstructCnt++;
                instructText.text = setupInstructions[setupInstructCnt];
            } else
            {
                InitializePlayInstructions();
                instructText.text = playInstructions[playInstructCnt];
                UIManager.Instance.currentDialogueState = UIManager.DialogueState.TurnInstruct;
            }
        } else if (UIManager.Instance.currentDialogueState == UIManager.DialogueState.TurnInstruct)
        {
            if (playInstructCnt < totPlayInstruct-1)
            {
                playInstructCnt++;
                instructText.text = playInstructions[playInstructCnt];
            } else
            {
                UIManager.Instance.ShowTopicCanvas();
            }
        }
        
    }

    public void SetPreviousInsruct()
    {
        if (UIManager.Instance.currentDialogueState == UIManager.DialogueState.Setup)
        {
            if (setupInstructCnt > 0)
            {
                setupInstructCnt--;
                instructText.text = setupInstructions[setupInstructCnt];
            }
        } else if (UIManager.Instance.currentDialogueState == UIManager.DialogueState.TurnInstruct)
        {
            if (playInstructCnt > 0)
            {
                playInstructCnt--;
                instructText.text = playInstructions[playInstructCnt];
            } else if (playInstructCnt == 0)
            {
                UIManager.Instance.currentDialogueState = UIManager.DialogueState.Setup;
                //decrementing here would skip a line
                instructText.text = setupInstructions[setupInstructCnt];
            }
        }
    }
    #endregion

    #region Helper Functions
    private void InitializeSetupInstructions()
    {
        //The same for now - will go back and change later
        if (UIManager.Instance.currentVersion == UIManager.Version.Version1)
        {
            setupInstructions = new string[]
            {"SETUP V1:",
            "Put the game board on a play surface that is comfortably accessible to all players.",
            "Seat players around the board at the four indication symbols.",
            "All players pick a constant position to sit, this is the only position that you are allowed to consider the game board from.",
            "Place the structural materials in a location where they are accessible to every player."};
            setupInstructCnt = 0;
            totSetupInstruct = setupInstructions.Length;
        }
        else if (UIManager.Instance.currentVersion == UIManager.Version.Version2)
        {
            setupInstructions = new string[]
            {"SETUP V2:",
            "Put the game board on a play surface that is comfortably accessible to all players.",
            "Seat players around the board at the four indication symbols.",
            "All players pick a constant position to sit, this is the only position that you are allowed to consider the game board from.",
            "Place the structural materials in a location where they are accessible to every player."};
            setupInstructCnt = 0;
            totSetupInstruct = setupInstructions.Length;
        }
        else if (UIManager.Instance.currentVersion == UIManager.Version.Version3)
        {
            setupInstructions = new string[]
            {"SETUP V3:",
            "Put the game board on a play surface that is comfortably accessible to all players.",
            "Seat players around the board at the four indication symbols.",
            "All players pick a constant position to sit, this is the only position that you are allowed to consider the game board from.",
            "Place the structural materials in a location where they are accessible to every player."};
            setupInstructCnt = 0;
            totSetupInstruct = setupInstructions.Length;
        }
    }

    private void InitializePlayInstructions()
    {
        if (UIManager.Instance.currentVersion == UIManager.Version.Version1)
        {
            playInstructions = new string[]
             {"HOW TO PLAY V1:",
            "Instruction 1.",
            "Instruction 2.",
            "Instruction 3."};
            playInstructCnt = 0;
            totPlayInstruct = playInstructions.Length;
        } else if (UIManager.Instance.currentVersion == UIManager.Version.Version2)
        {
            playInstructions = new string[]
             {"HOW TO PLAY V2:",
            "Instruction 1.",
            "Instruction 2.",
            "Instruction 3."};
            playInstructCnt = 0;
            totPlayInstruct = playInstructions.Length;
        } else if (UIManager.Instance.currentVersion == UIManager.Version.Version3)
        {
            playInstructions = new string[]
             {"HOW TO PLAY V3:",
            "Instruction 1.",
            "Instruction 2.",
            "Instruction 3."};
            playInstructCnt = 0;
            totPlayInstruct = playInstructions.Length;
        }
    }
    #endregion
}
