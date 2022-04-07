using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{

    //�{�[���̌�����\���̂��邚���̍ŏ��l
    private float visiblePosZ = -6.5f;

    //�Q�[���I�[�o��\������e�L�X�g
    private GameObject gameoverText;

    //�ۑ�F���_�e�L�X�g
    private GameObject scoredisplayText;

    private int ScoreText = 0;

    private string objName;

    // Start is called before the first frame update
    void Start()
    {
        //�V�[����GameoverText�I�u�W�F�N�g���擾
        this.gameoverText = GameObject.Find("GameOverText");

        //�ۑ�F�V�[����ScoreDisplay�I�u�W�F�N�g���擾
        this.scoredisplayText = GameObject.Find("ScoreDisplay");
        this.scoredisplayText.GetComponent<Text>().text = "���_�F"+ ScoreText ;
    }

    // Update is called once per frame
    void Update()
    {
        //�{�[������ʊO�ɏo���ꍇ
        if (this.transform.position.z < this.visiblePosZ)
        {
            //GameoverText�ɃQ�[���I�[�o��\��
            this.gameoverText.GetComponent<Text>().text = "Game Over";
        }

        this.scoredisplayText.GetComponent<Text>().text = "���_�F" + ScoreText;
    }
    void OnCollisionEnter(Collision other)
    {

        //�p�x��180�ɐݒ�
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
