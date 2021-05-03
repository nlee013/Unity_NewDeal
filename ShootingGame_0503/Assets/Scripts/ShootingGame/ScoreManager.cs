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


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
