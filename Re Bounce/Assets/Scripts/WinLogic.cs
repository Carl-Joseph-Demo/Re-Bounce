using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinLogic : MonoBehaviour
{
    private GameObject player;
    public GameObject startingPoint;
    public Text winText;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            winText.gameObject.SetActive(true);
        }
    }

    public void ExitApplication() 
    {
            Application.Quit();
    }
}
