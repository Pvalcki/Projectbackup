using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class start : MonoBehaviour
{
    public GameObject EmptyPanel;
    public GameObject Panel;
    public GameObject Menu;
    public GameObject Menu2;
    public GameObject Trigger;

    public void Starter()
    {

        if (EmptyPanel != null)
        {
            Panel.SetActive(false);
            Menu.SetActive(false);
            Menu2.SetActive(false);
            Trigger.SetActive(false);
        }
        
    }


}
