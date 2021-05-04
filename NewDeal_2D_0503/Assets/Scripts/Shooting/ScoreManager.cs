using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{

    // 현재 스코어
    public int currentScore;

    // 최고 스코어
    public int bestScore;

    // 현재스코어 Text
    public Text currentScoreTxt;

    // 최고스코어 Text
    public Text bestScoreTxt;

    // Start is called before the first frame update
    void Start()
    {

        // 게임이 시작될때 bestScore에 PlayerPrefs의 Set 함수를 이용하여 불러옴
        bestScore = PlayerPrefs.GetInt("Best Score", 0);

        // Best Score 를 UI text에 표시해준다
        bestScoreTxt.text = "최고 점수 : " + bestScore;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // 점수 가져오는 Get함수
    public int GetScore()
    {
        return currentScore;
    }

    //점수 저장하는 Set함수
    public void SetScore(int value)
    {
        // 3. ScoreManager의 currentScore를 증가
        currentScore++;

        // 4. UI Text에 currentScore를 표시
        currentScoreTxt.text = "현재 점수 : " + currentScore;

        // 최고점수 비교
        // 만약 현재점수가 최고 점수보다 크다면
        if (currentScore > bestScore)
        {
            // 새로운 최고 점수로 표시
            bestScore = currentScore;

            // ScoreManager의 Text에 표시
            bestScoreTxt.text = "최고 점수 : " + bestScore;

            // PlayerPrefs에 최고점수 저장
            PlayerPrefs.SetInt("Best Score", bestScore);
        }

    }
}
