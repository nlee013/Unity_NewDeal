using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class LoadImageTest : MonoBehaviour
{
    string filePath; //경로 함수 생성
    public UnityEngine.UI.Image img;

    // Start is called before the first frame update
    void Start()
    {
        filePath = Application.persistentDataPath + @"\saveimage\i.png";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadImage()
    {
        if (File.Exists(filePath))
        {
            //json으로 그림 설정 불러와서 width, height에 적용
            var tt = File.ReadAllBytes(filePath);
            Texture2D texture = new Texture2D(500, 500);
            texture.LoadImage(tt);
            Sprite sp = Sprite.Create(texture, new Rect(0, 0, 749, 499), new Vector2(0.5f, 0), 1);

            img.sprite = sp;
        }
        
    }

    
}

//그림을 저장할 때 너비, 높이도 같이 저장하고 그림으 불러올 때 너비, 높이를 불러와서
//해당 크기에 맞게 부르게 할 것.

