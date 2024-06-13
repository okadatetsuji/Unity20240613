using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class ScoreScript : MonoBehaviour
{
    // �N���X�̗B��̃C���X�^���X��ێ����邽�߂̐ÓI�ȕϐ�
    public static ScoreScript instance;
    // �X�R�A�̕\�����邽�߂�text�R���|�[�l���g�ƃg�[�^���X�R�A
    public GameObject scoreText;
    private int totalScore = 0;

    // �v���C�x�[�g�R���X�g���N�^
    private void Awake()
    {
        // �C���X�^���X�����݂��Ȃ��ꍇ�͂��̃C���X�^���X��ݒ�
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);      // �V�[�����܂����ł��C���X�^���X��ێ�
        }
        // ���ɑ��݂���ꍇ�͐V�����C���X�^���X��j��
        else
        {
            Destroy(gameObject);
        }
    }
    // ���f����邽�߂̃��\�b�h���`
    private void Start()
    {
        // �����\��
        UpdateScoreText();
    }
    // �X�R�A���X�V���āAText�R���|�[�l���g�ɔ��f����
    public void ScoreManager(int score)
    {
        totalScore += score;
        // �R���|�[�l���g��\������
        UpdateScoreText();
    }
    // �X�R�A��Text�R���|�[�l���g�ɕ\�����郁�\�b�h
    private void UpdateScoreText()
    {
        this.scoreText.GetComponent<TextMeshProUGUI>().text = "Score :"+ totalScore.ToString();
    }
}
