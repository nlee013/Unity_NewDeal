using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using Newtonsoft.Json;

//그림을 저장할 내용을 담은 클래스

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

        SaveImageFormatTest test = new SaveImageFormatTest(); //저장할 ㅇ리미지만 저장을 해뒀다가 걔만
        test.images = imageSource.sprite.texture;

        var bytes = test.images.EncodeToPNG();
        File.WriteAllBytes(folderpath + filepath, bytes);
    }
    //// Update is called once per frame
    //void Update()
    //{

    //}
    
}
