using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Enemy�� �Ʒ��� �̵��Ѵ�
/// �ʿ�Ӽ� : �̵��ӵ�
/// 1. �̻��� ���� ���ϱ�
/// 2. �̵��ϱ�
/// 3. �浹�ϰ� �Ǹ� �Ѵ� Destory����
/// </summary>

/// <summary>
/// 30%�� Ȯ���� Player������ �������� �Ʒ� �������� �̵��ϰ� ����
/// 1. Random�Լ��� ����Ͽ� 
/// 2. 30%�� player������ �̵�
///    a. �÷��̾ ã��
///    b. ���ⱸ�ϱ�
/// 3. �������� �Ʒ���
/// </summary>

public class EnemyMove : MonoBehaviour
{

    // �̵��ӵ�
    public float speed = 5;
    public GameObject effect;

    // ���� ����
    Vector3 dir;

    void Start()
    {
        // 1.Random�Լ��� ����Ͽ� => 0 ���� 9�ȿ��� ���� int ��
        int ranValue = Random.Range(0, 10);

        // 2. 30%�� player������ �̵�
        if (ranValue < 3)
        {
            // a.�÷��̾ ã��
            GameObject player = GameObject.Find("Player");

            // b.���ⱸ�ϱ� : �÷��̾��� ���� (Player������ - Enemy������) : ���� ����
            dir = player.transform.position - transform.position;

            //  ���� ũ�� ���� 1�� �����
            dir.Normalize();
        }
        else
        {
            // 3. �������� �Ʒ���
            dir = Vector3.down;
        }



    }

    void Update()
    {
        // 1. ����(�Ʒ�) ���ϱ�
        // Vector3 dir = Vector3.down;

        // 2. �̵��ϱ� P = P0 +vt
        transform.position += dir * speed * Time.deltaTime;

        
    }


    private void OnCollisionEnter(Collision collision)
    {
        //�̻���, player�� �浹�ϸ� ���� ����Ʈ
        //�ʿ� �Ӽ� : ���� prefab
        //1.�浹�ϸ�
        //2.���� �������� �����
        //3.Enemy ��ġ�� ���´�

        // collision = �浹�� ����



        //���� gameobject �ı�
        Destroy(collision.gameObject);

        //�ڱ��ڽ� gameobject �ı�
        Destroy(gameObject);

        

        


    }
}
