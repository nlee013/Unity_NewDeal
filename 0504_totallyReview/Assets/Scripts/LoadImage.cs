using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using Newtonsoft.Json;
using UnityEngine.UI;

public class LoadImage : MonoBehaviour
{
    public int width, height;
    [SerializeField] Image loadedImage;

    string filepath;
    [SerializeField] Text file;

    // Start is called before the first frame update
    void Start()
    {
        filepath = Application.persistentDataPath + @"\SaveImage" + @"\L" + file.text + "LINA.png";

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Load()
    {
        if (File.Exists(filepath))
        {
            var data = File.ReadAllBytes(filepath);
            Texture2D texture = new Texture2D(width, height);
            texture.LoadImage(data);

            Sprite sp = Sprite.Create(texture, new Rect(new Vector2(1080, 1057), new Vector2(width, height)),new Vector2(0.5f, 0), 1);
            //new Vector2(0, 0), new Vector2(width, height)
            loadedImage.sprite = sp;
        }
    }
}
