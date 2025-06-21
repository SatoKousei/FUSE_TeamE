using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ringo : MonoBehaviour
{
    public PlayerHP playerHP; // PlayerHPスクリプトへの参照  
    private void Start()
    {
        playerHP = GetComponent<PlayerHP>();
    }
    void Update()
    {
    }
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("リンゴを取ったよ！"); // デバッグ用メッセージ

        
    }
    private void OnTriggerEnter(Collider collision)
    {
        //if (collision.gameObject.CompareTag("Enemy"))
        //{
        //    // ここでスコア加算や効果音再生なども可能
        //    Destroy(gameObject); // りんごを消す

        //}
        if (collision.gameObject.CompareTag("Player"))
        {
            // ここでスコア加算や効果音再生なども可能
            Destroy(gameObject); // りんごを消す
            Debug.Log("リンゴを取ったよ！"); // デバッグ用メッセージ

        }
    }

}
