using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ringo : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("�����S���������I"); // �f�o�b�O�p���b�Z�[�W

        
    }
    private void OnTriggerEnter(Collider collision)
    {
        //if (collision.gameObject.CompareTag("Enemy"))
        //{
        //    // �����ŃX�R�A���Z����ʉ��Đ��Ȃǂ��\
        //    Destroy(gameObject); // ��񂲂�����

        //}
        if (collision.gameObject.CompareTag("Player"))
        {
            // �����ŃX�R�A���Z����ʉ��Đ��Ȃǂ��\
            Destroy(gameObject); // ��񂲂�����
            Debug.Log("�����S���������I"); // �f�o�b�O�p���b�Z�[�W

        }
    }

}
