using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] float moveSpeed = 2f;
    [SerializeField] float escapeSpeed = 4f;
    [SerializeField] GameObject ringoPrefab; // Inspector�ŃA�T�C��
    bool isEscaping = false;
    bool hasDropped = false; // 1�񂾂����Ƃ��p

    void Update()
    {
        if (isEscaping)
        {
            transform.Translate(Vector3.right * escapeSpeed * Time.deltaTime);

            // �����n�߂��u�Ԃ�1�x���������S�𐶐��i�R���[�`���Œx���j
            if (!hasDropped)
            {
                StartCoroutine(DropRingoWithDelay(1.0f)); // 1�b��Ƀ����S�𗎂Ƃ�
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
            // Enemy�̌���i�������j��1.0f�������炵�ă����S�𐶐�
            Vector3 dropOffset = -transform.right * 1.0f; // ����������̋t
            Vector3 dropPosition = transform.position + dropOffset;
            Instantiate(ringoPrefab, dropPosition, Quaternion.identity);
        }
    }
}
