using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    //minimum time
    [SerializeField]
    float minTime = 1;

    //maximum time
    float maxTime = 5;

    //현재 시간
    float currentTime = 0;

    //일정 시간
    [SerializeField] float appearTime = 1;

    //적 프리펩
    [SerializeField] GameObject enemyPrefabs;


    // Start is called before the first frame update
    void Start()
    {
        //처음 적이 생성 될 시간 설정
        //currentTime = Random.Range(minTime, maxTime);
    }

    // Update is called once per frame
    void Update()
    {
        //1. 시간이 흐른다
        currentTime += Time.deltaTime;

        //2. 일정한 시간이 되면
        if (currentTime > appearTime)
        {
            //3.적을 생성한다
            GameObject enemy = Instantiate(enemyPrefabs);

            //4. 위치로 놓는다
            enemy.transform.position = transform.position;

            //5. 시간을 0으로 초기화한다.
            currentTime = 0;

            //적이 생성 후 적 생성 시간 다시 설정
            currentTime = Random.Range(minTime, maxTime);
        }
    }
}
