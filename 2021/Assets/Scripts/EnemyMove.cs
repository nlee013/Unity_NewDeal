using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    [SerializeField] float enemySpeed = 5;

    public GameObject EnemyPrefabs;
    //public Transform EneyPosition;
    
    Vector3 dir; //= Vector3.down;

    // Start is called before the first frame update
    void Start()
    {
        //���� ��������
        

        //1.random�Լ� ��� if�� -> 0~9�ȿ��� ���� int��
        int ranValue = Random.Range(0, 10);
        
        //2.30%�� player������ �̵��ϰ� �����
        if (ranValue <= 3)
        {
            //Find A player
            GameObject player = GameObject.Find("Player");

            //Find a direction : Player direction (Player position - Enemy position) : direction vector
            dir = player.transform.position - transform.position;
            // Create a direction scale about Vector one. = Returns this vector with a magnitude of 1 
            dir.Normalize();
        }
        else
        {
            //3.�������� �Ʒ���
            dir = Vector3.down;
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(dir * enemySpeed * Time.deltaTime);
        //1.�̻��� ���� ���ϱ�
        //Vector3.dir = Vector3.down;

        //2.�̵��ϱ� P-PO ;
        //transform position += dir * speed * Time.deltaTIme;
    }

    //ó�� �浹�Ǿ����� �� �� ���� ȣ��Ǵ� ����Ƽ �̺�Ʈ �Լ�
    private void OnCollisionEnter(Collision collision)
    {
        //collision = �浹�� ����

        //���� gameobject �ı�
        Destroy(collision.gameObject);

        //�ڱ� �ڽ� gameobject �ı�
        Destroy(gameObject);
    }
}
