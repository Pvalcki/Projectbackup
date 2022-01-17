using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Subtitles1 : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject textBox;
    public GameObject motion;


    public void Start()
    {
       
        StartCoroutine(Sequence());
    }

    // Update is called once per frame
    IEnumerator Sequence()
    {
        yield return new WaitForSeconds(5.95f);
        textBox.GetComponent<Text>().text = "Hey there!";
        yield return new WaitForSeconds(0.8f);
        textBox.GetComponent<Text>().text = "My name is Ron, ";
        yield return new WaitForSeconds(1.4F);
        textBox.GetComponent<Text>().text = "I will be your robot assistent here";
        yield return new WaitForSeconds(2);
        textBox.GetComponent<Text>().text = "at the hospital Nebule.";
        yield return new WaitForSeconds(1.4f);
        textBox.GetComponent<Text>().text = "You probably wonder";
        yield return new WaitForSeconds(1.3f);
        textBox.GetComponent<Text>().text = "how you are able to move?";
        yield return new WaitForSeconds(1.4f);
        textBox.GetComponent<Text>().text = "Well, to rotate your view";
        yield return new WaitForSeconds(1.8f);
        textBox.GetComponent<Text>().text = "Use the joystick on your right controller";
        motion.SetActive(true);
        yield return new WaitForSeconds(2.2f);
        textBox.GetComponent<Text>().text = "To move around";
        yield return new WaitForSeconds(1.5f);
        textBox.GetComponent<Text>().text = "Use the joystick on your left controller.";
        yield return new WaitForSeconds(2.3f);
        textBox.GetComponent<Text>().text = "It is that easy!";
        yield return new WaitForSeconds(3);
        textBox.GetComponent<Text>().text = "Well done! ";
        yield return new WaitForSeconds(1);
        textBox.GetComponent<Text>().text = "You now master the basic mechanics of the game.";
        yield return new WaitForSeconds(2.9f);
        textBox.GetComponent<Text>().text = "Once you are ready,";
        yield return new WaitForSeconds(1f);
        textBox.GetComponent<Text>().text = "you can follow me to the patient his room.";
        yield return new WaitForSeconds(2f);
        textBox.GetComponent<Text>().text = "Today you will be doing a check up";
        yield return new WaitForSeconds(2f);
        textBox.GetComponent<Text>().text = "on Patient 125.";
        yield return new WaitForSeconds(1.5f);
        textBox.GetComponent<Text>().text = "He had an accident at the harvester";
        yield return new WaitForSeconds(2f);
        textBox.GetComponent<Text>().text = "in section 1O4.";
        yield return new WaitForSeconds(2.5f);
        textBox.GetComponent<Text>().text = "If you go stand inside this blue circle,";
        yield return new WaitForSeconds(2f);
        textBox.GetComponent<Text>().text = "the startscreen will pop up.";
        yield return new WaitForSeconds(2f);
        textBox.GetComponent<Text>().text = "Here you can start the game,";
        yield return new WaitForSeconds(2f);
        textBox.GetComponent<Text>().text = "choose a level or adjust your settings.";
        yield return new WaitForSeconds(2.3f);
        textBox.GetComponent<Text>().text = "To interact with a button,";
        yield return new WaitForSeconds(1.5f);
        textBox.GetComponent<Text>().text = "point the ray towards this specific button";
        yield return new WaitForSeconds(2.3f);
        textBox.GetComponent<Text>().text = "and press the right trigger to continue.";
        yield return new WaitForSeconds(3);
        textBox.GetComponent<Text>().text = "Once you are ready,";
        yield return new WaitForSeconds(1);
        textBox.GetComponent<Text>().text = "press start to begin the level.";
        yield return new WaitForSeconds(2.5f);
        
        textBox.GetComponent<Text>().text = "";
       
    }
}
