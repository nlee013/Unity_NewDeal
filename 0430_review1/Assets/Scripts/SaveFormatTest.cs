using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;
using System.IO;

//그림을 저장할 내용을 담은 클래스

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
