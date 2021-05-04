using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Best Core를 표시한다
//필요속성 : 최고 점수, 최고점수UI(Text)
//1. enemy를 파괴하면
//2. 최고점수와 비교
//3. 최고점수보다 높다면 새로운 최고 점수로 표시
//4. UI text를 통해 표시

public class ScoreManager : MonoBehaviour
{
    public int CurrentScore;
    public int BestScore;

    public Text CurentScoretxt;
    public Text BestScoretxt;

    //게임이 다시 실행될 때 최고점수를 미리 표시해둔다
    //1. 게임이 시작될 때 best socre에 playerprefas의get함수를 이용해 불러온 값을 할당함
    //2. best 점수ui에 표시함

    // Start is called before the first frame update
    void Start()
    {
        BestScore = PlayerPrefs.GetInt("Best Score", 0);

        // Best Score 를 UI text에 표시해준다
        BestScoretxt.text = "최고 점수 : " + BestScore;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public int GetScore()
    {
        return CurrentScore;
    }

    public void SetScore(int value)
    {
        ////3.score manager 컴포넌트(게임 오브젝트) 안에 current score를 증가시킨다
        //sm.CurrentScore++; //sm.CurrentScore += 1; sm.CurrentScore = sm.CurrentScore + 1;

        ////4. UI Text에 current score를 표시한다
        //sm.CurentScoretxt.text = "Current score : " + sm.CurrentScore;

        ////2.최고 점수와 비교
        ////만약 현재 점수가 best score보다 크다면
        //if (sm.CurrentScore > sm.BestScore)
        //{
        //    //3. 최고점수보다 높다면 새로운 점수로 표시
        //    sm.BestScore = sm.CurrentScore;

        //    //4. UI text를 통해 표시
        //    sm.BestScoretxt.text = "Best score : " + sm.BestScore;

        //}
    }
}
