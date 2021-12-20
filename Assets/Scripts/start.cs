using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class start : MonoBehaviour
{
    public GameObject EmptyPanel;
    public GameObject Panel;
    public GameObject Menu;
    public GameObject Trigger;
    public GameObject Watch;
    public GameObject WatchBorder;
    public GameObject WatchRender;


    public void Starter()
    {

        if (EmptyPanel != null)
        {
            Panel.SetActive(false);
            Menu.SetActive(false);
            Trigger.SetActive(true);
            Watch.SetActive(true);
            Watch.SetActive(true);
            WatchBorder.SetActive(true);
            WatchRender.SetActive(true);
        }
        
    }


}
