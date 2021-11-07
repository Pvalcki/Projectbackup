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
    

    public void Play()
    {
        playableDirector.Play();
        robotski.SetActive(false);
        stopDirector.Stop();
        playableDirector2.Play();

    }
}
