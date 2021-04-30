using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public abstract class OperateTest : MonoBehaviour
{
    public abstract void Action();

     void OnEnable()
    {
        ActionTest.Instance.MultipleOperate += Action;
    }

    void OnDisable()
    {
        ActionTest.Instance.MultipleOperate -= Action;
    }
    // public MTest mTest;
    // public ActionTest actionTest;

    // Start is called before the first frame update
    void Start()
    {
        //Button b = GetComponent<Button>();
        //AudioSource audio = GetComponent<AudioSource>();
        //b.onClick.AddListener(delegate () { audio.Play(); });
       
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
