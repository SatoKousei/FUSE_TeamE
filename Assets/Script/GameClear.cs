using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameClear : MonoBehaviour
{
    void Update()
    {
        // 何かキーが押されたら"Title"シーンに遷移
        if (Input.anyKeyDown)
        {
            SceneManager.LoadScene("Title");
        }
    }
}
