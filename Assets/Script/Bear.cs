using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bear : MonoBehaviour
{
    [SerializeField] float moveSpeed = 3f; // �E�ړ��̑���

    void Update()
    {
        // D�L�[��Z���������݈̂ړ�
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(0, 0, 1 * Time.deltaTime);
        }
    }
}
