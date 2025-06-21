using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kids : MonoBehaviour
{
    [SerializeField] Player p;
    private bool isStopped = false;
    void Start()
    {
        GameObject o = GameObject.Find("Bear"); // ‚±‚±‚ðBear_4‚É
    }

    void Update()
    {
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
