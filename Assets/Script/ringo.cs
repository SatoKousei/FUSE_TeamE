using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ringo : MonoBehaviour
{
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            // �����ŃX�R�A���Z����ʉ��Đ��Ȃǂ��\
            Destroy(gameObject); // ��񂲂�����

        }
        if (collision.gameObject.CompareTag("Player"))
        {
            // �����ŃX�R�A���Z����ʉ��Đ��Ȃǂ��\
            Destroy(gameObject); // ��񂲂�����
        }
    }
}
