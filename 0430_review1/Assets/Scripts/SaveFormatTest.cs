using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;
using System.IO;

//�׸��� ������ ������ ���� Ŭ����

public class SaveFormatTest
{
    public string name;
    public int age;
    public Dictionary<string, int> personaladdress;
    public Sprite sprite;

    public SaveFormatTest(string name, int age)
    {
        this.name = name;
        this.age = age;

    }

}
