using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//���邳�̐���N���X
public class BrightnessRegulator : MonoBehaviour
{

    //Material������
    Material myMaterial;

    //Emission�̍ŏ���
    private float minEmission = 0.2f;

    //Emission�̋��x
    private float magEmission = 2.0f;

    //�p�x
    private int degree = 0;

    //�������x
    private int speed = 5;

    //�^�[�Q�b�g�̃f�t�H���g�̐F
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

        //�I�u�W�F�N�g�ɃA�^�b�`���Ă���Material���擾
        //Renderer�Ƃ̓����_�����O����@�\�Ȃǂ��w��
        this.myMaterial = GetComponent<Renderer> ().material;

        //�I�u�W�F�N�g�̍ŏ��̐F��ݒ�
        myMaterial.SetColor("_EmissionColor", this.defaultColor * minEmission);

    }

    // Update is called once per frame
    void Update()
    {
        if (this.degree >= 0)
        {
            //���点�鋭�x�̌v�Z
            //Mathf.Deg2Rad���x���@�̊p�x�����W�A���i�ʓx�@�j�ɕϊ�(2��/360)
            Color emissionColor = this.defaultColor * (this.minEmission + Mathf.Sin(this.degree * Mathf.Deg2Rad) * this.magEmission);

            //Emission�ɐF��ݒ肷��
            myMaterial.SetColor("_EmissionColor", emissionColor);

            //���݂̊p�x������������
            //�킯�킩���H�x��-�������x�H�H�H�H
            this.degree -= this.speed;

        }
    }

    void OnCollisionEnter(Collision other)
    {
        //�p�x��180�ɐݒ�
        this.degree = 180;
    }
}
