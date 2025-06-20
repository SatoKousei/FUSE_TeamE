using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Title : MonoBehaviour
{
    void Update()
    {
        // 何かキーが押されたら"Stage"シーンに切り替え
        if (Input.anyKeyDown)
        {
            SceneManager.LoadScene("Stage");
        }
    }
}
