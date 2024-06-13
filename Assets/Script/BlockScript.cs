using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockScript : MonoBehaviour
{
    public int score = 10;
    // 何かとぶつかったときビルトインメソッド
    private void OnCollisionEnter(Collision collision)
    {
        //ScoreScript.instance.set
        // スコアをScoreScriptから追加
        if(ScoreScript.instance != null)
        {
            ScoreScript.instance.ScoreManager(score);
        }
        else
        {
            Debug.LogError("インスタンスがありません");
        }
        // ゲームオブジェクトを削除
        Destroy(gameObject);
    }
}
