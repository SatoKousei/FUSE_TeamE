using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody rb;
    bool isGround = false;  //地面にいるかどうか
    float timer;
    Animator animator; // 追加

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>(); // 追加
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.forward * 3 * Time.deltaTime);
            if (Input.GetKey(KeyCode.D))
            {
                transform.Translate(Vector3.forward * 3 * Time.deltaTime);
                animator.Play("Walk Forward"); // ステート名を直接指定
            }
            else
            {
                animator.Play("Idle");
            }
            animator.SetBool("Walk Forward", true); // 歩くモーションに
        }
        else
        {
            animator.SetBool("Idle", false); // 待機モーションに
        }

        Vector3 camera_pos = Camera.main.transform.position;
        camera_pos.x = transform.position.x;
        Camera.main.transform.position = camera_pos;
    }
}
