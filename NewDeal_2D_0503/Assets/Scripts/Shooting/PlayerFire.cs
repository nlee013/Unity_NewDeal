using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// ��ư�� ������ �̻����� ������������
/// �ʿ�Ӽ� : �̻���������(����), �̻����� ���� ��ġ
/// 1. ��ư�� ������
/// 2. �̻��� �������� �����
/// 3. �̻����� �߻��Ѵ�
/// </summary>

public class PlayerFire : MonoBehaviour
{

    // �̻����� ������ ������
    public GameObject missilePrefabs;

    // �̻����� ���� ��ġ
    public GameObject missilePos;

    // Button UI
    public Button fireBtn;

    void Start()
    {

    }


    void Update()
    {
        // 1. (Fire1)��ư�� ������
        if (Input.GetButtonDown("Fire1"))
        {
            // 2. �̻��� �������� �����
            GameObject missile = Instantiate(missilePrefabs);

            // 3. �̻����� �߻��Ѵ�
            missile.transform.position = missilePos.transform.position;
        }
    }
}
