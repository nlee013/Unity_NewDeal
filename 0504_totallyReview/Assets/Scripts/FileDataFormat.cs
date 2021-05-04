using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using Newtonsoft.Json;

[SerializeField]

public class FileDataFormat : MonoBehaviour
{
    public string Name;
    public int age;
    public int phoneNumber;
    public int width, height;

   // public List<PlayerPrefs Name>;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public FileDataFormat(string Name, int age, int phoneNumber, int width, int height)
    {
        this.Name = Name;
        this.age = age;
        this.phoneNumber = phoneNumber;
        this.width = width;
        this.height = height;

    }
}
