using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class start : MonoBehaviour
{
    public GameObject EmptyPanel;
    public GameObject Panel;
    public GameObject Menu;
    
    public GameObject Watch;
   

    public void Starter()
    {

        if (EmptyPanel != null)
        {
            Panel.SetActive(false);
            Menu.SetActive(false);
            
            Watch.SetActive(true);
        }
        
    }


}
