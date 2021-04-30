using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// �̻����� ���� �̵��ϵ�������
/// �ʿ�Ӽ� : �̻��� �ӵ�
/// 1. ���� ���ϱ�
/// 2. �̵��ϱ�
/// </summary>
public class Missile : MonoBehaviour
{
    // �̻��� �ӵ�
    public float speed = 5;


    void Start()
    {

    }

    void Update()
    {
        // ���ⱸ�ϱ�
        Vector3 dir = Vector3.up;

        // �̵��ϱ� P = P0 + vt
        transform.position += dir * speed * Time.deltaTime;
    }
}
