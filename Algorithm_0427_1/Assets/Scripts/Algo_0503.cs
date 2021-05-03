using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//신호감지
//높이(숫자)가 
public class Algo_0503 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            int[] temps = { 5, 8, 3, 6, 9 };
            int[] values = checked(temps);
            for(int i = 0; i < values.Length; i++)
            {
                print(values[i]); //[0, 0, 2, 2]
            }
        }
    }

    int[] Check(int[] height)
    {
        int[] nums = new int[height.Length];

        //구현
       // #region
        return nums;
    }

    
}
