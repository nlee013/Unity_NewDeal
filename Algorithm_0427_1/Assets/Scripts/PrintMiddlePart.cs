using System.Collections;
using System.Collections.Generic;
using UnityEngine;

string tempA = "NewDeal";
string tempB = "Deal";

public class PrintMiddlePart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            string middleword = PickMiddleWords(tempA);
            print(middleword);
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            string middleword = PickMiddleWords(tempB);
            print(middleword);
        }
    }

    string PickMiddleWords(string word)
    {
        //reset
        string middleWord = "";

        //create
        return middlenUM = word.Length / 2;

        if(word.Length % 2 == 0)
        {
            middleWord += word[middleNum - 1];
        }

    }
}
