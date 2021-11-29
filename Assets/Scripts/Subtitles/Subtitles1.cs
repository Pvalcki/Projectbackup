using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Subtitles1 : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject textBox;
   
    
    public void Start()
    {
       
        StartCoroutine(Sequence());
    }

    // Update is called once per frame
    IEnumerator Sequence()
    {
        yield return new WaitForSeconds(10);
        textBox.GetComponent<Text>().text = "Hey, you are finally here!";
        yield return new WaitForSeconds(2.2f);
        textBox.GetComponent<Text>().text = "My name is Ron, ";
        yield return new WaitForSeconds(2);
        textBox.GetComponent<Text>().text = "I will be your robot assistent here";
        yield return new WaitForSeconds(1.5f);
        textBox.GetComponent<Text>().text = "at the hospital Nebule.";
        yield return new WaitForSeconds(1);
        textBox.GetComponent<Text>().text = "To rotate your view, use your right joystick";
        yield return new WaitForSeconds(3.5f);
        textBox.GetComponent<Text>().text = "To move, use your joystick on your left hand.";
        yield return new WaitForSeconds(3);
        textBox.GetComponent<Text>().text = "Well done!";
        yield return new WaitForSeconds(1  );
        textBox.GetComponent<Text>().text = "You now mastered the basic mechanics of the game!";
        yield return new WaitForSeconds(3.5f);
        textBox.GetComponent<Text>().text = "Now follow me to the patient his room.";
        yield return new WaitForSeconds(3f);
        textBox.GetComponent<Text>().text = "";
       

    }
}
