using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Best Core�� ǥ���Ѵ�
//�ʿ�Ӽ� : �ְ� ����, �ְ�����UI(Text)
//1. enemy�� �ı��ϸ�
//2. �ְ������� ��
//3. �ְ��������� ���ٸ� ���ο� �ְ� ������ ǥ��
//4. UI text�� ���� ǥ��

public class ScoreManager : MonoBehaviour
{
    public int CurrentScore;
    public int BestScore;

    public Text CurentScoretxt;
    public Text BestScoretxt;

    //������ �ٽ� ����� �� �ְ������� �̸� ǥ���صд�
    //1. ������ ���۵� �� best socre�� playerprefas��get�Լ��� �̿��� �ҷ��� ���� �Ҵ���
    //2. best ����ui�� ǥ����

    // Start is called before the first frame update
    void Start()
    {
        BestScore = PlayerPrefs.GetInt("Best Score", 0);

        // Best Score �� UI text�� ǥ�����ش�
        BestScoretxt.text = "�ְ� ���� : " + BestScore;
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
        ////3.score manager ������Ʈ(���� ������Ʈ) �ȿ� current score�� ������Ų��
        //sm.CurrentScore++; //sm.CurrentScore += 1; sm.CurrentScore = sm.CurrentScore + 1;

        ////4. UI Text�� current score�� ǥ���Ѵ�
        //sm.CurentScoretxt.text = "Current score : " + sm.CurrentScore;

        ////2.�ְ� ������ ��
        ////���� ���� ������ best score���� ũ�ٸ�
        //if (sm.CurrentScore > sm.BestScore)
        //{
        //    //3. �ְ��������� ���ٸ� ���ο� ������ ǥ��
        //    sm.BestScore = sm.CurrentScore;

        //    //4. UI text�� ���� ǥ��
        //    sm.BestScoretxt.text = "Best score : " + sm.BestScore;

        //}
    }
}
