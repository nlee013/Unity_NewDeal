using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Ű�� ������ �� Ȱ��/ ��Ȱ���� �ݺ��ǵ���..
//Ű�� ���� ���¿����� ������Ʈ�� Ȱ��ȭ�ǵ��� return Ű���� Ȱ��.

public class ReturnTest : MonoBehaviour
{
    public GameObject target, ActivationObject, ActiveRelationObject;
    public Canvas canvas;

    [SerializeField] Text[] texts; //���̾��Ű���� ����� �� ��� ����

    // Start is called before the first frame update
    void Start()
    {
        //gameObject.SetActive(true);//���� ������Ʈ Ȱ��ȭ.���⿡ false�� �ҷ����� script�� ���� ������ ��Ȱ��

        var temp = FindObjectsOfType<GameObject>();

        foreach(var te in temp)
        {
            print(te.name);

           if(te.GetComponent<Rigidbody>())
            {
                te.GetComponent<Rigidbody>().isKinematic = false;
            }
        }
        //Canvas�� Random�� ���ڷ� Textâ�� ����� Text()�� ���� �Է��ؼ� ȭ�鿡 ���̰� �����

       
       
        //texts[0].gameObject.SetActive(true);
        //texts[0].ReturnTest.texts;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //gameObject.SetActive(true);

            ////ActivationObject.SetActive(!ActivationObject.activeSelf);

            var b = Random.Range(0, texts.Length);

            foreach(var text in texts)
            {
                text.enabled = false;
            }

            for (int i = 0; i < b; i++)
            {
                texts[i].text = Random.Range(0, 77).ToString();
                texts[i].enabled = true;
            }
        }
        else
        {
            //gameObject.SetActive(false); 
            //-> ���ӿ�����Ʈ�� ����ϸ� ���⼭ ��ũ��Ʈ ��ɵ� ����.
        }

        if (Input.GetMouseButton(0))
        {
            //gameObject.activeSelf = !gameObject.activeSelf
            //->�ٸ������� ���ӿ�����Ʈ�� �����ͼ� �����ϸ� ��ũ��Ʈ�� ����.

            target.SetActive(false);
            //ActivationObject.SetActive(true);

            return;
        }
        //ActiveRelationObject.SetActive(false);
        target.SetActive(true);

        //var a = GetComponent<Collider>();
        //a.enabled = true;

        //�� ���� ������Ʈ�� ã�� ��� �̸��� ����ϱ� �̸��� ����ϸ� �ϳ��� �������ϸ�..
        //�� ��ȭ�ϴ� ��ɵ� �߰�
    }
}
