using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FripperController : MonoBehaviour
{

    // HingeJointコンポーネントを入れる
    private HingeJoint myHingeJoint;

    // 初期の傾き
    private float defaultAngle = 20;

    // 弾いた時の傾き
    private float flickAngle = -20;

    // Start is called before the first frame update
    void Start()
    {

        // HingeJointコンポーネント取得
        this.myHingeJoint = GetComponent<HingeJoint>();

        // フリッパーの傾きを設定
        SetAngle(this.defaultAngle);

    }

    // Update is called once per frame
    void Update()
    {

        // 左矢印キーを押したとき、左フリッパーを動かす
        if (Input.GetKeyDown(KeyCode.LeftArrow) && tag == "LeftFripperTag")
        {
            SetAngle(this.flickAngle);
        }

        // 右矢印キーを押したとき、右フリッパーを動かす
        if (Input.GetKeyDown(KeyCode.RightArrow) && tag == "RightFripperTag")
        {
            SetAngle(this.flickAngle);
        }



        // 左矢印キーを離したとき、左フリッパーをもとに戻す
        if (Input.GetKeyUp(KeyCode.LeftArrow) && tag == "LeftFripperTag")
        {
            SetAngle(this.defaultAngle);
        }

        // 右矢印キーを離したとき、右フリッパーを元に戻す
        if (Input.GetKeyUp(KeyCode.RightArrow) && tag == "RightFripperTag")
        {
            SetAngle(this.defaultAngle);
        }


    }

    //フリッパーの傾き制御
    public void SetAngle(float angle)
    {
        JointSpring jointSpr = this.myHingeJoint.spring;
        jointSpr.targetPosition = angle;
        this.myHingeJoint.spring = jointSpr;

    }
}
