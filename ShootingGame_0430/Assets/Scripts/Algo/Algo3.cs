using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Algo3 : MonoBehaviour
{
    string tempA = "newDeal";
    string tempB = "dEAl";

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            string middleword = PickMiddleWords(tempA);
            print(middleword);
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            string middleword = PickMiddleWords(tempB);
            print(middleword);
        }

    }

    string PickMiddleWords(string word)
    {
        // �ʱ�ȭ
        string middleWord = "";

        // ����
        int middleNum = word.Length / 2;

        // string�� Ȧ������ ¦������ Ȯ������
        if(word.Length % 2 == 0)
        {
            middleWord += word[middleNum - 1];
        }

        // middleWord �� �ֱ�
        middleWord = middleWord + word[middleNum];

        // ȣ���Ѱ����� ��ȯ
        return middleWord;
    }

}
