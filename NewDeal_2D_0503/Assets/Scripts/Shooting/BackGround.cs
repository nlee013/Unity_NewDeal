using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Offset�� �̿��Ͽ� ����� ��������
/// �ʿ�Ӽ� : Material, �����̴� �ӵ�
/// 1. �����̴� ����
/// 2. offset ����
/// </summary>

public class BackGround : MonoBehaviour
{
    //Material
    public Material backgoundMaterial;

    //�����̴� �ӵ�
    [Range(0f,1f)]
    public float moveSpeed = 0.5f;

    void Update()
    {
        // 1. �����̴� ����
        Vector2 dir = Vector2.up;

        // 2. offset ���� P = P0 + vt
        backgoundMaterial.mainTextureOffset += dir * moveSpeed * Time.deltaTime;
    }

}
