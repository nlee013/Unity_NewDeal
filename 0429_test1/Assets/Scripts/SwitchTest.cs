using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchTest : MonoBehaviour
{
    //key���� �޾� ������Ʈ ������ ��ȯ�ϵ���
    
    Renderer cube1; // ������ ������ �ִ� ��
    int randomColor = 0; // ���� : ����ġ������ case�� ���ڸ� ������ �ִ� ��

    // Start is called before the first frame update
    void Start()
    {
        cube1 = gameObject.GetComponent<Renderer>();
    }

    //123, 212, 212

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            switch (randomColor)
            {
                case 0:
                    cube1.material.color = Color.black;
                    break;

                case 1:
                    cube1.material.color = Color.blue;
                    break;

                case 2:
                    cube1.material.color = Color.red;
                    break;

                case 3:
                    cube1.material.color = Color.green;
                    break;
            }
        }

        randomColor = Random.Range(0, 4);
    }
}
