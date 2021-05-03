using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using Newtonsoft.Json;

//�׸��� ������ ������ ���� Ŭ����

public class SaveImageTest : MonoBehaviour
{
    //public string name;
    //public int age;
    //public Dictionary<string, int> personaladdress;
    //public Sprite sprite;

    string folderpath;
    string filepath;
    public UnityEngine.UI.Image imageSource;

    // Start is called before the first frame update
    void Start()
    {
        folderpath = Application.persistentDataPath + @"\saveimage";
        filepath = @"\i.png";
    }

    public void SaveImage()
    {
        if (!Directory.Exists(folderpath))
        {
            Directory.CreateDirectory(folderpath);
        }

        SaveImageFormatTest test = new SaveImageFormatTest(); //������ ���������� ������ �ص״ٰ� �¸�
        test.images = imageSource.sprite.texture;

        var bytes = test.images.EncodeToPNG();
        File.WriteAllBytes(folderpath + filepath, bytes);
    }
    //// Update is called once per frame
    //void Update()
    //{

    //}
    
}
