using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gameend : MonoBehaviour
{
    private bool DayClear = false;
    // Update is called once per frame
    void Update()
    {
        if (DayClear)
        {
            SceneManager.LoadScene("Clear");
            DayClear = false;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            DayClear = true;
        }
    }
}