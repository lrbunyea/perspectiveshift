using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VersionCanvasController : MonoBehaviour
{
    #region Variables
    [SerializeField] Toggle ver1;
    [SerializeField] Toggle ver2;
    [SerializeField] Toggle ver3;
    #endregion 
    
    public void SetVersion()
    {
        if (ver1.isOn)
        {
            UIManager.Instance.currentVersion = UIManager.Version.Version1;
        } else if (ver2.isOn)
        {
            UIManager.Instance.currentVersion = UIManager.Version.Version2;
        } else if (ver3.isOn)
        {
            UIManager.Instance.currentVersion = UIManager.Version.Version3;
        }
        UIManager.Instance.StartInstructions();
    }
}
