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
        //방향 변수벡터
        

        //1.random함수 사용 if문 -> 0~9안에서 렌덤 int값
        int ranValue = Random.Range(0, 10);
        
        //2.30%는 player쪽으로 이동하게 만들기
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
            //3.나머지는 아래로
            dir = Vector3.down;
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(dir * enemySpeed * Time.deltaTime);
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
