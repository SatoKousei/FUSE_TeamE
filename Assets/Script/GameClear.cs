using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameClear : MonoBehaviour
{
    void Update()
    {
        // �����L�[�������ꂽ��"Title"�V�[���ɑJ��
        if (Input.anyKeyDown)
        {
            SceneManager.LoadScene("Title");
        }
    }
}
