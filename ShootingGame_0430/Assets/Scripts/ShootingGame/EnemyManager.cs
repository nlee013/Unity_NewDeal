using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ���� �ð����� Enemy�� �����ϰ� �ʹ�
/// �ʿ�Ӽ� : �ð�(�����ѽð�,����ð�), ������
/// 1. �ð��� �帥��
/// 2. ������ �ð��� �Ǹ�
/// 3. ���� �����Ѵ�
/// 4. ��ġ�� ���´�
/// </summary>

/// <summary>
/// �����Լ��� �̿��Ͽ� Enemy�� �ұ�Ģ�ϰ� ��������
/// �ʿ� �Ӽ� : �ּ�, �ִ�
/// </summary>
/// 
public class EnemyManager : MonoBehaviour
{
    // �ּ� 
    [SerializeField]
    float minTime = 1;

    // �ִ�
    [SerializeField]
    float maxTime = 5;

    // ���� �ð�
    float currentTime = 0;

    // ���� �ð�
    [SerializeField]
    float appearTime = 1;

    // �� ������
    [SerializeField]
    GameObject enemyPrefab;

    void Start()
    {
        // ó�� ���� ���� �ɽð� ����
        appearTime = Random.Range(minTime, maxTime);
    }

    void Update()
    {
        // 1. �ð��� �帥��
        currentTime += Time.deltaTime;

        // 2. ������ �ð��� �Ǹ�
        if (currentTime > appearTime)
        {
            // 3. ���� �����Ѵ�
            GameObject enemy = Instantiate(enemyPrefab);

            // 4. ��ġ�� ���´�
            enemy.transform.position = transform.position;

            // 5. �ð��� 0���� �ʱ�ȭ
            currentTime = 0;

            // ���� ������ �� ���� �ð� �ٽ� ����
            appearTime = Random.Range(minTime, maxTime);
        }

    }
}
