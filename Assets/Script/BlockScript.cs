using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockScript : MonoBehaviour
{
    public int score = 10;
    // �����ƂԂ������Ƃ��r���g�C�����\�b�h
    private void OnCollisionEnter(Collision collision)
    {
        ScoreScript.instance.set
        // �Q�[���I�u�W�F�N�g���폜
        Destroy(gameObject);
    }
}
