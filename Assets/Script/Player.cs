using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody rb;
    bool isGround = false;
    float timer;
    Animator animator;
    BoxCollider boxCollider;
    Vector3 defaultSize;
    Vector3 defaultCenter;
    Vector3 attackSize;
    Vector3 attackCenter;
    AudioBehaviour au;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
        boxCollider = GetComponent<BoxCollider>();
        defaultSize = boxCollider.size;
        defaultCenter = boxCollider.center;
        au = GetComponent<AudioBehaviour>();

        // Z方向だけ前方にずらす
        attackSize = new Vector3(defaultSize.x, defaultSize.y, 5f);
        attackCenter = defaultCenter + new Vector3(0, 0, 2f);
    }

    void Update()
    {
        // DキーでZ軸正方向のみ移動
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(0, 0, 1 * Time.deltaTime);
            animator.SetBool("Walk", true);
        }
        else
        {
            animator.SetBool("Walk", false);
        }

        // スペースキーで攻撃
        if (Input.GetKeyDown(KeyCode.Space))
        {
            au.GetComponent<AudioSource>().Play();
            animator.SetBool("Attack", true);
            boxCollider.size = attackSize;
            boxCollider.center = attackCenter;
        }
        else if (Input.GetKeyUp(KeyCode.Space))
        {
            animator.SetBool("Attack", false);
            boxCollider.size = defaultSize;
            boxCollider.center = defaultCenter;
        }

        // カメラ追従
        Vector3 camera_pos = Camera.main.transform.position;
        camera_pos.x = transform.position.x + 3;
        Camera.main.transform.position = camera_pos;
    }
}
