using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kids : MonoBehaviour
{
    [SerializeField] Player p;
    void Start()
    {
        GameObject o = GameObject.Find("Player");
        p = o.GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 v = p.transform.position - transform.position;
        v.Normalize();
        transform.Translate(v * Time.deltaTime);
    }
}