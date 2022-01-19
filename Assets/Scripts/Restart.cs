using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;
using System.Threading;

public class Restart : MonoBehaviour
{
    
    public PlayableDirector stopDirector;
    public GameObject Watch;



    public void Play()
    {

        stopDirector.Stop();
        Watch.SetActive(false);
        StartCoroutine(ExecuteAfterTime(1));
        



}


    IEnumerator ExecuteAfterTime(float time)
    {
        yield return new WaitForSeconds(time);

        Application.Quit();
    }

   
}
