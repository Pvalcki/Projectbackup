using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Playables;

public class SwitchScene1 : MonoBehaviour
{
    public GameObject docking;
    public GameObject plane;
    public GameObject character;
    public GameObject cube;
    public GameObject frame;
    public GameObject motion;
    public GameObject director;
    public PlayableDirector stopDirector;


    void OnTriggerEnter (Collider other)
    {
        motion.SetActive(false);
        director.SetActive(false);
        stopDirector.Stop();
                docking.SetActive(false);
        plane.SetActive(false);
        character.SetActive(false);
        frame.SetActive(false);
        cube.SetActive(false);
    }
}
