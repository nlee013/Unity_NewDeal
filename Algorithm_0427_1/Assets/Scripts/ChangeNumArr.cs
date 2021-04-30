using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeNumArr : MonoBehaviour
{
    public int[] numArr = new int[46];
    private static readonly Random random = new Random();

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 1; i < numArr.Length; i++)
        {
            numArr[i] = i;
        }
    }

    // Update is called once per frame
    void Update()
    {
        //함수 호출

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //ChangeNumArr()
            //{
                //string allNum = "";
                
                for (int i = 0; i < numArr.Length; i++)
                {
                var random = new Random();
                list.Add(random.Next())
                    //allNum = allNum + numArr[i];
                    //allNum = allNum + "";

                    numArr[i] = random.Next();
                }

                //print(allNum);
            //}

            
        }
    }

}
