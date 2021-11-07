using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class NewChoice : MonoBehaviour
{
    public PlayableDirector playableDirector;
    public PlayableDirector stopDirector;

    public void Play()
    {
        stopDirector.Stop();
        playableDirector.Play();

    }
}

