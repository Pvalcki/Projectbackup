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
    public GameObject previousScene;
    public GameObject currentScene;


    public void Play()
    {
        previousScene.SetActive(false);
        currentScene.SetActive(true);
        stopDirector.Stop();
        playableDirector.Play();
        Watch.SetActive(false);
        Watch2.SetActive(true);

    }
}

