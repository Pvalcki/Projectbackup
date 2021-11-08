using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class NewChoice : MonoBehaviour
{
    public PlayableDirector playableDirector;
    public PlayableDirector stopDirector;
    public GameObject Watch;
    public GameObject Watch2;

    public void Play()
    {
        stopDirector.Stop();
        playableDirector.Play();
        Watch.SetActive(false);
        Watch2.SetActive(true);

    }
}

