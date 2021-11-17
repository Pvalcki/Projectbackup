using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{

    public PlayableDirector stopDirector;
    public GameObject Watch;
    

    public void Play()
    {
        stopDirector.Stop();
        Watch.SetActive(false);
        SceneManager.LoadScene("Hospital_Testing_HDRP_02");

    }
}
