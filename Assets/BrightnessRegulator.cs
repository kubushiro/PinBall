using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//明るさの制御クラス
public class BrightnessRegulator : MonoBehaviour
{

    //Materialを入れる
    Material myMaterial;

    //Emissionの最小化
    private float minEmission = 0.2f;

    //Emissionの強度
    private float magEmission = 2.0f;

    //角度
    private int degree = 0;

    //発光速度
    private int speed = 5;

    //ターゲットのデフォルトの色
    Color defaultColor = Color.white;


    // Start is called before the first frame update
    void Start()
    {
        if (tag == "SmallStarTag")
        {
            this.defaultColor = Color.white;
        }
        else if (tag == "LargeStarTag")
        {
            this.defaultColor = Color.yellow;
        }
        else if (tag == "SmallCloudTag" || tag == "LargeCloudTag")
        {
            this.defaultColor = Color.cyan;
        }

        //オブジェクトにアタッチしているMaterialを取得
        //Rendererとはレンダリングする機能などを指す
        this.myMaterial = GetComponent<Renderer> ().material;

        //オブジェクトの最初の色を設定
        myMaterial.SetColor("_EmissionColor", this.defaultColor * minEmission);

    }

    // Update is called once per frame
    void Update()
    {
        if (this.degree >= 0)
        {
            //光らせる強度の計算
            //Mathf.Deg2Rad→度数法の角度をラジアン（弧度法）に変換(2π/360)
            Color emissionColor = this.defaultColor * (this.minEmission + Mathf.Sin(this.degree * Mathf.Deg2Rad) * this.magEmission);

            //Emissionに色を設定する
            myMaterial.SetColor("_EmissionColor", emissionColor);

            //現在の角度を小さくする
            //わけわからん？度数-発光速度？？？？
            this.degree -= this.speed;

        }
    }

    void OnCollisionEnter(Collision other)
    {
        //角度を180に設定
        this.degree = 180;
    }
}
