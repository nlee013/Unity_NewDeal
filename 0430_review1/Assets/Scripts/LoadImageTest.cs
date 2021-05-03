using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class LoadImageTest : MonoBehaviour
{
    string filePath; //��� �Լ� ����
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
            //json���� �׸� ���� �ҷ��ͼ� width, height�� ����
            var tt = File.ReadAllBytes(filePath);
            Texture2D texture = new Texture2D(500, 500);
            texture.LoadImage(tt);
            Sprite sp = Sprite.Create(texture, new Rect(0, 0, 749, 499), new Vector2(0.5f, 0), 1);

            img.sprite = sp;
        }
        
    }

    
}

//�׸��� ������ �� �ʺ�, ���̵� ���� �����ϰ� �׸��� �ҷ��� �� �ʺ�, ���̸� �ҷ��ͼ�
//�ش� ũ�⿡ �°� �θ��� �� ��.

