using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody rb;
    bool isGround = false;  //�n�ʂɂ��邩�ǂ���
    float timer;
    Animator animator; // �ǉ�

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>(); // �ǉ�
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.forward * 3 * Time.deltaTime);
            if (Input.GetKey(KeyCode.D))
            {
                transform.Translate(Vector3.forward * 3 * Time.deltaTime);
                animator.Play("Walk Forward"); // �X�e�[�g���𒼐ڎw��
            }
            else
            {
                animator.Play("Idle");
            }
            animator.SetBool("Walk Forward", true); // �������[�V������
        }
        else
        {
            animator.SetBool("Idle", false); // �ҋ@���[�V������
        }

        Vector3 camera_pos = Camera.main.transform.position;
        camera_pos.x = transform.position.x;
        Camera.main.transform.position = camera_pos;
    }
}
