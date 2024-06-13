using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockScript : MonoBehaviour
{
    public int score = 10;
    // 何かとぶつかったときビルトインメソッド
    private void OnCollisionEnter(Collision collision)
    {
        ScoreScript.instance.set
        // ゲームオブジェクトを削除
        Destroy(gameObject);
    }
}
