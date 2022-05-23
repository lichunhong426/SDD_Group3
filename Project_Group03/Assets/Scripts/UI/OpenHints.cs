using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenHints : MonoBehaviour
{
    public GameObject open;
    public GameObject SettingPanel;
    public GameObject OptionPanel;
    // Start is called before the first frame update
    
    public void OpenPanel()
    {
        open.SetActive(true);
        SettingPanel.SetActive(false);
        OptionPanel.SetActive(false);
    }





}
