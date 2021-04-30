using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ��ư�� ������ �̻����� ������������
/// �ʿ�Ӽ� : �̻���������(����), �̻����� ���� ��ġ
/// 1. ��ư�� ������
/// 2. �̻��� �������� �����
/// 3. �̻����� �߻��Ѵ�
/// </summary>

public class PlayerFIre : MonoBehaviour
{

    // �̻����� ������ ������
    public GameObject missilePrefabs;

    // �̻����� ���� ��ġ
    public GameObject missilePos;

    void Start()
    {

    }


    void Update()
    {
        // 1. (Fire1)��ư�� ������
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // 2. �̻��� �������� �����
            GameObject missile = Instantiate(missilePrefabs);

            // 3. �̻����� �߻��Ѵ�
            missile.transform.position = missilePos.transform.position;
        }

    }
}
