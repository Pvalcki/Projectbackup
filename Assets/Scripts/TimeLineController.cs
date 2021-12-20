using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class TimeLineController : MonoBehaviour
{
    public PlayableDirector playableDirector;
    public PlayableDirector stopDirector;
    public PlayableDirector playableDirector2;
    public GameObject robotski;
    public GameObject robotskiweg;
    public GameObject firstScene;



    public void Play()
    {

        firstScene.SetActive(true);
        
        playableDirector.Play();
        
        robotski.SetActive(false);
        robotskiweg.SetActive(true);
        stopDirector.Stop();
        playableDirector2.Play();

    }


}

