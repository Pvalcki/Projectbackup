using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instellingen : MonoBehaviour
{
    public GameObject PanelOpen;
    public GameObject PanelClose;


    public void OpenPanel()
    {
        if (PanelOpen != null)
        {
            PanelOpen.SetActive(true);
            PanelClose.SetActive(false);
        }
    }
}
