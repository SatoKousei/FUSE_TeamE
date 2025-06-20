using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody rb;
    bool isGround = false;  //’n–Ê‚É‚¢‚é‚©‚Ç‚¤‚©
    float timer;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal") * Time.deltaTime;
        transform.Translate(Vector3.right * h * 3);

        Vector3 camera_pos = Camera.main.transform.position;
        camera_pos.x = transform.position.x;
        Camera.main.transform.position = camera_pos;
    }
}
