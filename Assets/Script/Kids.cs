using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kids : MonoBehaviour
{
    [SerializeField] Player p;
    private bool isStopped = false;

    void Start()
    {
        GameObject o = GameObject.Find("Player");
        p = o.GetComponent<Player>();
    }

    void Update()
    {
        if (isStopped) return;

        Vector3 v = p.transform.position - transform.position;
        v.Normalize();
        v.y = 0; // yŽ²•ûŒü‚ÌˆÚ“®‚Í‚µ‚È‚¢
        transform.Translate(v * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            isStopped = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            isStopped = false;
        }
    }
}
