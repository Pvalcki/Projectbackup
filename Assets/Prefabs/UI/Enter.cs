using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enter : MonoBehaviour
{
    public GameObject Panel;
    public GameObject Menu;
    public GameObject Menu2;

    private void OnTriggerEnter(Collider other)
    {
        if (Panel != null)
        {
            Panel.SetActive(true);
        }

        if (Menu != null)
        {
            Menu.SetActive(true);
        }

        if (Menu2 != null)
        {
            Menu2.SetActive(true);
        }
    }


}
