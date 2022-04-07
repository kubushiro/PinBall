using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FripperController : MonoBehaviour
{

    // HingeJoint�R���|�[�l���g������
    private HingeJoint myHingeJoint;

    // �����̌X��
    private float defaultAngle = 20;

    // �e�������̌X��
    private float flickAngle = -20;

    // Start is called before the first frame update
    void Start()
    {

        // HingeJoint�R���|�[�l���g�擾
        this.myHingeJoint = GetComponent<HingeJoint>();

        // �t���b�p�[�̌X����ݒ�
        SetAngle(this.defaultAngle);

    }

    // Update is called once per frame
    void Update()
    {

        //// �����L�[���������Ƃ��A���t���b�p�[�𓮂���
        //if (Input.GetKeyDown(KeyCode.LeftArrow) && tag == "LeftFripperTag")
        //{
        //    SetAngle(this.flickAngle);
        //}

        //// �E���L�[���������Ƃ��A�E�t���b�p�[�𓮂���
        //if (Input.GetKeyDown(KeyCode.RightArrow) && tag == "RightFripperTag")
        //{
        //    SetAngle(this.flickAngle);
        //}


        //// �����L�[�𗣂����Ƃ��A���t���b�p�[�����Ƃɖ߂�
        //if (Input.GetKeyUp(KeyCode.LeftArrow) && tag == "LeftFripperTag")
        //{
        //    SetAngle(this.defaultAngle);
        //}

        //// �E���L�[�𗣂����Ƃ��A�E�t���b�p�[�����ɖ߂�
        //if (Input.GetKeyUp(KeyCode.RightArrow) && tag == "RightFripperTag")
        //{
        //    SetAngle(this.defaultAngle);
        //}


        //���W�ۑ�
        // �����L�[���������Ƃ��A���t���b�p�[�𓮂���
        if (Input.GetKeyDown(KeyCode.LeftArrow) && tag == "LeftFripperTag" || Input.GetKeyDown(KeyCode.A) && tag == "LeftFripperTag")
        {
            SetAngle(this.flickAngle);
        }
        //  �R�[�h�������Ȃ邽�ߕ���
        if (Input.GetKeyDown(KeyCode.S) && tag == "LeftFripperTag" || Input.GetKeyDown(KeyCode.DownArrow) && tag == "LeftFripperTag")
        {
            SetAngle(this.flickAngle);
        }

        // �E���L�[���������Ƃ��A�E�t���b�p�[�𓮂���
        if (Input.GetKeyDown(KeyCode.RightArrow) && tag == "RightFripperTag" || Input.GetKeyDown(KeyCode.D) && tag == "RightFripperTag")
        {
            SetAngle(this.flickAngle);
        }
        //  �R�[�h�������Ȃ邽�ߕ���
        if (Input.GetKeyDown(KeyCode.S) && tag == "RightFripperTag" || Input.GetKeyDown(KeyCode.DownArrow) && tag == "RightFripperTag")
        {
            SetAngle(this.flickAngle);
        }

        //���W�ۑ�
        // �����L�[�𗣂����Ƃ��A���t���b�p�[�����Ƃɖ߂�
        if (Input.GetKeyUp(KeyCode.LeftArrow) && tag == "LeftFripperTag" || Input.GetKeyUp(KeyCode.A) && tag == "LeftFripperTag")
        {
            SetAngle(this.defaultAngle);
        }
        //  �R�[�h�������Ȃ邽�ߕ���
        if (Input.GetKeyUp(KeyCode.S) && tag == "LeftFripperTag" || Input.GetKeyUp(KeyCode.DownArrow) && tag == "LeftFripperTag")
        {
            SetAngle(this.defaultAngle);
        }

        // �E���L�[�𗣂����Ƃ��A�E�t���b�p�[�����ɖ߂�
        if (Input.GetKeyUp(KeyCode.RightArrow) && tag == "RightFripperTag" || Input.GetKeyUp(KeyCode.D) && tag == "RightFripperTag")
        {
            SetAngle(this.defaultAngle);
        }
        //  �R�[�h�������Ȃ邽�ߕ���
        if (Input.GetKeyUp(KeyCode.S) && tag == "RightFripperTag" || Input.GetKeyUp(KeyCode.DownArrow) && tag == "RightFripperTag")
        {
            SetAngle(this.defaultAngle);
        }

    }

    //�t���b�p�[�̌X������
    public void SetAngle(float angle)
    {
        JointSpring jointSpr = this.myHingeJoint.spring;
        jointSpr.targetPosition = angle;
        this.myHingeJoint.spring = jointSpr;

    }
}
