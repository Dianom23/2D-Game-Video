using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    private int _coinCoint;
    private Wallet _wallet;

    // Start is called before the first frame update
    void Start()
    {
        _coinCoint = GameObject.FindGameObjectsWithTag("Coin").Length;
        _wallet = FindObjectOfType<Wallet>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag != "Player") return;
        if(_coinCoint != _wallet.count) return;

        int lastSceneIndex = SceneManager.sceneCountInBuildSettings - 1;
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        if (lastSceneIndex == currentSceneIndex)
        {
            SceneManager.LoadScene(0);
        }
        else
        {
            SceneManager.LoadScene(currentSceneIndex + 1);
        }
    }
}
