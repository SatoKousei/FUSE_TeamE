using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] float moveSpeed = 2f;
    [SerializeField] float escapeSpeed = 4f;
    [SerializeField] GameObject ringoPrefab; // Inspectorでアサイン
    bool isEscaping = false;
    bool hasDropped = false; // 1回だけ落とす用

    void Update()
    {
        if (isEscaping)
        {
            transform.Translate(Vector3.right * escapeSpeed * Time.deltaTime);

            // 逃げ始めた瞬間に1度だけリンゴを生成（コルーチンで遅延）
            if (!hasDropped)
            {
                StartCoroutine(DropRingoWithDelay(1.0f)); // 1秒後にリンゴを落とす
                hasDropped = true;
            }
        }
        else
        {
            transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            isEscaping = true;
        }
    }

    IEnumerator DropRingoWithDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        if (ringoPrefab != null)
        {
            // Enemyの後方（左方向）に1.0fだけずらしてリンゴを生成
            Vector3 dropOffset = -transform.right * 1.0f; // 逃げる方向の逆
            Vector3 dropPosition = transform.position + dropOffset;
            Instantiate(ringoPrefab, dropPosition, Quaternion.identity);
        }
    }
}
