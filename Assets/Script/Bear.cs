using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bear : MonoBehaviour
{
    [SerializeField] float moveSpeed = 3f; // ‰EˆÚ“®‚Ì‘¬‚³

    void Update()
    {
        // DƒL[‚ÅZ²³•ûŒü‚Ì‚İˆÚ“®
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(0, 0, 1 * Time.deltaTime);
        }
    }
}
