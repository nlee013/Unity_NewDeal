using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// DestroyBar�� ������Ʈ�� ������ ���� Object�� �ı��Ѵ�
/// OnTriggerEnter ����Ͽ� �����
/// </summary>

public class DestoryBar : MonoBehaviour
{
    //DestroyBar�� ������Ʈ�� ������ 
    private void OnTriggerEnter(Collider other)
    {
        //���� Object�� �ı��Ѵ�
        Destroy(other.gameObject);
    }

}
