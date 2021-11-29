using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;
using System.Threading;

public class Restart : MonoBehaviour
{
    public PlayableDirector playDirector;
    public PlayableDirector stopDirector;
    public GameObject Watch;



    public void Play()
    {

        stopDirector.Stop();
        playDirector.Play();
        StartCoroutine(ExecuteAfterTime(5));
        



    }


    IEnumerator ExecuteAfterTime(float time)
    {
        yield return new WaitForSeconds(time);

        SceneManager.LoadScene("Hospital_Testing_HDRP_02");
    }

   
}
