using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class WelcomeScript : MonoBehaviour
{

    public TMP_Text canvasText;
    public Image blackbox;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        canvasText.text = "Welcome to my aquarium! Explore and see if you can find all 5 animal types. Enjoy!";
        blackbox.color = new Color32(0, 0, 0, 255);
    }

    private void OnTriggerExit(Collider other)
    {
        canvasText.text = "";
        blackbox.color = new Color32(0, 0, 0, 0);
    }
}
