using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Playables;

public class ToggleMenu : MonoBehaviour
{

    public List <PlayableDirector> playableDirectors;

    public InputActionReference toggleReference = null;

    public GameObject Pauze;

    protected bool IsPaused = false;

     

    private void Awake()
    {
        toggleReference.action.started += Toggle;
    }

    private void OnDestroy()
    {
        toggleReference.action.started -= Toggle;
    }

    private void Toggle(InputAction.CallbackContext context)
    {
        //bool isActive = !gameObject.activeSelf;
        //gameObject.SetActive(isActive);
        foreach (PlayableDirector director in playableDirectors)
        {
            
                if (!IsPaused)
                {
                    director.Pause();
                    IsPaused = true;
                
                }
                else
                {
                    director.Resume();
                    IsPaused = false;
                }

            
        }
       
    }
}