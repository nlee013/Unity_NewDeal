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
        //1.미사일 방향 구하기
        //Vector3.dir = Vector3.down;

        //2.이동하기 P-PO ;
        //transform position += dir * speed * Time.deltaTIme;
    }

    //처음 충돌되엇을때 딱 한 번만 호출되는 유니티 이벤트 함수
    private void OnCollisionEnter(Collision collision)
    {
        //collision = 충돌한 상대방

        //상대방 gameobject 파괴
        Destroy(collision.gameObject);

        //자기 자신 gameobject 파괴
        Destroy(gameObject);
    }
}
