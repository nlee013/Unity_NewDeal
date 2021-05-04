using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using Newtonsoft.Json;
using UnityEngine.UI;

public class ChangeColour : MonoBehaviour
{
    [SerializeField] Image buttonImage;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ColourChange()
    {
        int temp = Random.Range(0, 5);
        Color buttonColor = new Color(0, 225, 0);
        switch (temp)
        {
            case 0:
                buttonColor = new Color(0.4f, 0.2f, 0);
                break;

            case 1:
                buttonColor = new Color(0, 0.04f, 0.6f);
                break;

            case 2:
                buttonColor = new Color(0, 0.7f, 0);
                break;

            case 3:
                buttonColor = new Color(0, 0.02f, 0.07f);
                break;


            case 4:
                buttonColor = new Color(7f, 0, 9f);
                break;

        }
        buttonImage.color = buttonColor;
    }

    public void RevertChange()
    {
        buttonImage.color = Color.white;
    }
}
