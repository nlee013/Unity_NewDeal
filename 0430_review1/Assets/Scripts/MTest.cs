using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class MTest : OperateTest
{
    public override void Action()
    {
        print("especial behaviour");
    }

    public class TTest : OperateTest
    {
        public override void Action()
        {
            //������ ����
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
