using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{

    //ボールの見える可能性のあるｚ軸の最小値
    private float visiblePosZ = -6.5f;

    //ゲームオーバを表示するテキスト
    private GameObject gameoverText;

    //課題：得点テキスト
    private GameObject scoredisplayText;

    private int ScoreText = 0;

    private string objName;

    // Start is called before the first frame update
    void Start()
    {
        //シーンのGameoverTextオブジェクトを取得
        this.gameoverText = GameObject.Find("GameOverText");

        //課題：シーンのScoreDisplayオブジェクトを取得
        this.scoredisplayText = GameObject.Find("ScoreDisplay");
        this.scoredisplayText.GetComponent<Text>().text = "得点："+ ScoreText ;
    }

    // Update is called once per frame
    void Update()
    {
        //ボールが画面外に出た場合
        if (this.transform.position.z < this.visiblePosZ)
        {
            //GameoverTextにゲームオーバを表示
            this.gameoverText.GetComponent<Text>().text = "Game Over";
        }

        this.scoredisplayText.GetComponent<Text>().text = "得点：" + ScoreText;
    }
    void OnCollisionEnter(Collision other)
    {

        //角度を180に設定
        this.objName = other.gameObject.tag;
        if (objName == "SmallStarTag")
        {
            this.ScoreText += 50;
        }
        else if (objName == "LargeStarTag")
        {
            this.ScoreText += 70;
        }
        else if (objName == "SmallCloudTag")
        {
            this.ScoreText += 20;
        }
        else if (objName == "LargeCloudTag")
        {
            this.ScoreText += 30;
        }
    }
}
