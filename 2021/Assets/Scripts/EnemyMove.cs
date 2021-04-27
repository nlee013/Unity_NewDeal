using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    [SerializeField] float enemySpeed = 5;


    //public GameObject EnemyPrefabs;
    //public Transform EneyPosition;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * enemySpeed * Time.deltaTime);
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
