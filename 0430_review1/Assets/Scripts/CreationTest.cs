using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//ť��� ť�긦 �̿��Ͽ� ������ �ϳ��� �����صΰ� Inputfield�� �̿��Ͽ� �ؽ�Ʈ �Է��� �ް�
//��ư�� ������ ������ ����-> ������ �̸��� inputfield�� �ִ� �̸�����  �ٲ�
//�⺻ �̸� "Adam"�� �Է��� ��

// : ���� �ٸ� ������Ʈ 5������ �̵�, ȸ��, ũ�� ��ȭ, ���̴� ����, ������ �ʴ� ����,
// ����ȭ, �Ҹ���� ���� �Լ��� �ְ� ���콺�� ������ 5������ �ൿ�� ���ÿ� �� �� �ֵ���
// (��ư Ȱ���� �ܿ�)

public class CreationTest : MonoBehaviour
{
    public GameObject adam;
    public Text nameContainer;
    public Transform creationPosiiton;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void creationAdam()
    {
        string adamname = nameContainer.text;
        adamname = adamname.Length > 0 ? adamname : "Adam";

        var a = Instantiate(adam, creationPosiiton);
        a.name = adamname;
    }
}
