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

    //���� �ð�
    float currentTime = 0;

    //���� �ð�
    [SerializeField] float appearTime = 1;

    //�� ������
    [SerializeField] GameObject enemyPrefabs;


    // Start is called before the first frame update
    void Start()
    {
        //ó�� ���� ���� �� �ð� ����
        //currentTime = Random.Range(minTime, maxTime);
    }

    // Update is called once per frame
    void Update()
    {
        //1. �ð��� �帥��
        currentTime += Time.deltaTime;

        //2. ������ �ð��� �Ǹ�
        if (currentTime > appearTime)
        {
            //3.���� �����Ѵ�
            GameObject enemy = Instantiate(enemyPrefabs);

            //4. ��ġ�� ���´�
            enemy.transform.position = transform.position;

            //5. �ð��� 0���� �ʱ�ȭ�Ѵ�.
            currentTime = 0;

            //���� ���� �� �� ���� �ð� �ٽ� ����
            currentTime = Random.Range(minTime, maxTime);
        }
    }
}
