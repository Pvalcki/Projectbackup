using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class Explore : MonoBehaviour
{
    // Start is called before the first frame update

    public PlayableDirector playDirector;
    public void Explorer()
    {
        playDirector.Play();
    }

    
}
