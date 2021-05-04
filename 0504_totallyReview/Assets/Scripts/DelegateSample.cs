using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DelegateSample : MonoBehaviour
{
    #region �Ӽ�
    public static DelegateSample Instance
    {
        get; set;
    }
    #endregion

    #region �̺�Ʈ(�븮��)
    public event Action SaveOperate;
    public event Action LoadOperate;
    public event EventHandler SaveEvent;
    public event EventHandler LoadEvent;


    #endregion

    #region �Լ�
    public void SaveOperation()
    {
        SaveOperate?.Invoke();
    }

    public void LoadOperation()
    {
        LoadOperate?.Invoke();
    }

    public void SaveEventOperation()
    {
        SaveEvent?.Invoke(this, EventArgs.Empty);
    }

    public void LoadEventOperation()
    {
        LoadEvent?.Invoke(this, EventArgs.Empty);
    }
    #endregion

    #region ����Ƽ �Լ�
    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
    }
    #endregion

}
