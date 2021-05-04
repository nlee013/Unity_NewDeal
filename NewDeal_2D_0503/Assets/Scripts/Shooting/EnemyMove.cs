using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Enemy가 아래로 이동한다
/// 필요속성 : 이동속도
/// 1. 미사일 방향 구하기
/// 2. 이동하기
/// 3. 충돌하게 되면 둘다 Destory하자
/// </summary>

/// <summary>
/// 30%로 확률로 Player쪽으로 나머지는 아래 방향으로 이동하게 하자
/// 1. Random함수를 사용하여 
/// 2. 30%는 player쪽으로 이동
///    a. 플레이어를 찾기
///    b. 방향구하기
/// 3. 나머지는 아래로
/// </summary>

/// <summary>
/// 미사일,Player와 충돌하면 폭발이팩트
/// 필요속성 : 폭발Prefab
/// 1. 충돌하면
/// 2. 폭발프리팹을 만든다
/// 3. Enemy위치에 놓는다
/// </summary>
public class EnemyMove : MonoBehaviour
{

    // 이동속도
    public float speed = 5;

    // 방향 변수
    Vector3 dir;

    // 폭발 프리팹
    public GameObject bombEffect;

    void Start()
    {

        // 1.Random함수를 사용하여 => 0 부터 9안에서 랜덤 int 값
        int ranValue = Random.Range(0, 10);

        // 2. 30%는 player쪽으로 이동
        if (ranValue < 3)
        {
            if (GameObject.Find("Player"))
            {
                // a.플레이어를 찾기
                GameObject player = GameObject.Find("Player");

                // b.방향구하기 : 플레이어쪽 방향 (Player포지션 - Enemy포지션) : 방향 벡터
                dir = player.transform.position - transform.position;

                //  방향 크기 벡터 1로 만들기
                dir.Normalize();
            }
        }
        else
        {
            // 3. 나머지는 아래로
            dir = Vector3.down;
        }


    }

    void Update()
    {
        // 1. 방향(아래) 구하기
        // Vector3 dir = Vector3.down;

        // 2. 이동하기 P = P0 +vt
        transform.position += dir * speed * Time.deltaTime;
    }


    private void OnCollisionEnter(Collision collision)
    {
        // collision = 충돌한 상대방
        
        // 1. ScoreManager 객체를 가져오자
        GameObject go = GameObject.Find("ScoreManager");

        // 2. ScoreManager의 <ScoreManager>컴포넌트를 가져오기
        ScoreManager sm = go.GetComponent<ScoreManager>();

        #region 점수계산을 ScoreManager가 할수있도록 SetScore함수로 이동
        // 3. ScoreManager의 currentScore를 증가
        // sm.currentScore++;

        // 4. UI Text에 currentScore를 표시
        // sm.currentScoreTxt.text = "현재 점수 : " + sm.currentScore;

        // 최고점수 비교
        // 만약 현재점수가 최고 점수보다 크다면
        // if (sm.currentScore > sm.bestScore)
        // {
        // 새로운 최고 점수로 표시
        // sm.bestScore = sm.currentScore;

        // ScoreManager의 Text에 표시
        // sm.bestScoreTxt.text = "최고 점수 : " + sm.bestScore;

        // PlayerPrefs에 최고점수 저장
        // PlayerPrefs.SetInt("Best Score", sm.bestScore);
        // }
        #endregion

        // ScoreManager 의 get set함수를 호출하여 처리하도록 하자
        int temp = sm.GetScore();
        sm.SetScore(temp++);

        // 2. 폭발프리팹을 만든다
        GameObject effect = Instantiate(bombEffect);

        // 3. Enemy위치에 놓는다
        effect.transform.position = transform.position;

        //상대방 gameobject 파괴
        Destroy(collision.gameObject);

        //자기자신 gameobject 파괴
        Destroy(gameObject);
        
    }
}
