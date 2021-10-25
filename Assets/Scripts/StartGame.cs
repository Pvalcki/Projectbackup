using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    public GameObject EmptyPanel;
    public GameObject Panel;
    public GameObject Menu;
    public GameObject Menu2;

    
    public void Start()
    {

        if (EmptyPanel != null)
        {
            Panel.SetActive(false);
            Menu.SetActive(false);
            Menu2.SetActive(false);
        }

    }
}
