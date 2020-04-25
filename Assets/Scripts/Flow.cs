using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flow : MonoBehaviour
{
    public GameObject panelHelp;
   
    public void CloseHelp()
    {
        panelHelp.SetActive(false);
    }

    public void OpenHelp()
    {
        panelHelp.SetActive(true);
    }

    public void ExitApp()
    {
        Application.Quit();
    }

}
