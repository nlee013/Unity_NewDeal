using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{

    // ���� ���ھ�
    public int currentScore;

    // �ְ� ���ھ�
    public int bestScore;

    // ���罺�ھ� Text
    public Text currentScoreTxt;

    // �ְ��ھ� Text
    public Text bestScoreTxt;

    // Start is called before the first frame update
    void Start()
    {

        // ������ ���۵ɶ� bestScore�� PlayerPrefs�� Set �Լ��� �̿��Ͽ� �ҷ���
        bestScore = PlayerPrefs.GetInt("Best Score", 0);

        // Best Score �� UI text�� ǥ�����ش�
        bestScoreTxt.text = "�ְ� ���� : " + bestScore;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // ���� �������� Get�Լ�
    public int GetScore()
    {
        return currentScore;
    }

    //���� �����ϴ� Set�Լ�
    public void SetScore(int value)
    {
        // 3. ScoreManager�� currentScore�� ����
        currentScore++;

        // 4. UI Text�� currentScore�� ǥ��
        currentScoreTxt.text = "���� ���� : " + currentScore;

        // �ְ����� ��
        // ���� ���������� �ְ� �������� ũ�ٸ�
        if (currentScore > bestScore)
        {
            // ���ο� �ְ� ������ ǥ��
            bestScore = currentScore;

            // ScoreManager�� Text�� ǥ��
            bestScoreTxt.text = "�ְ� ���� : " + bestScore;

            // PlayerPrefs�� �ְ����� ����
            PlayerPrefs.SetInt("Best Score", bestScore);
        }

    }
}
