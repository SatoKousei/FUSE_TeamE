using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Title : MonoBehaviour
{
    void Update()
    {
        // �����L�[�������ꂽ��"Stage"�V�[���ɐ؂�ւ�
        if (Input.anyKeyDown)
        {
            SceneManager.LoadScene("Stage");
        }
    }
}
