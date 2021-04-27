using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Algorithm : MonoBehaviour
{
    public int[] numArr = { 0, 1, 2, 3, 4 };
    int temp;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ChangeNumArr(0, 2);

            for (int i = 0; i < numArr.Length; i++)
            {
                print(numArr[i]);
            }
        }
    }

    void ChangeNumArr(int i, int j)
    {
        temp = numArr[i];
        numArr[i] = numArr[j];
        numArr[j] = temp;
    }
}

