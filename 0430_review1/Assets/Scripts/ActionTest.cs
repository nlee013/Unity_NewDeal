using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ActionTest : MonoBehaviour
{
    public static ActionTest Instance
    {
        get;
        set;
    }

    public Sprite[] sprites;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
    }

    public event Action MultipleOperate;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            MultipleOperate.Invoke();
        }
    }
}
