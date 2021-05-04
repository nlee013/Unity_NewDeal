using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using Newtonsoft.Json;
using UnityEngine.UI;

//그림 저장 클라스

public class SaveImage : MonoBehaviour
{
    [SerializeField] Image source;
    [SerializeField] Text file;

    string folderpath, filepath;

    // Start is called before the first frame update
    void Start()
    {
        folderpath = Application.persistentDataPath + @"\SaveImage";
        //filepath = @"\.png";

        if (!Directory.Exists(folderpath))
        {
            Directory.CreateDirectory(folderpath);
        }
        DelegateSample.Instance.SaveOperate += Save;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Save()
    {
        var data = source.sprite.texture.EncodeToPNG();
        filepath = @"\L" + file.text + "LINA.png";

        File.WriteAllBytes(folderpath + filepath, data);
    }
}
