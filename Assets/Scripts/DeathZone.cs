using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathZone : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Destroy(collision.gameObject);
            Invoke("LoadScene", 2);
        }
    }

    private void LoadScene()
    {
        SceneManager.LoadScene(0);
    }
}
