using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class Enter : MonoBehaviour
{
    public GameObject Panel;
    public PlayableDirector playDirector;
    
    public GameObject Menu;
    
    public GameObject Trigger;

    private void OnTriggerEnter(Collider other)
    {
        if (Panel != null)
        {
            Panel.SetActive(true);
        }

        if (Menu != null)
        {
            Menu.SetActive(true);
        }

        


        
        playDirector.Play();

        

        



        Trigger.SetActive(false);
    }




}
