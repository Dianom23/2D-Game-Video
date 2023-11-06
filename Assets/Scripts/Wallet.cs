using TMPro;
using UnityEngine;

public class Wallet : MonoBehaviour
{
    public int count;
    [SerializeField] private TextMeshProUGUI _text;

    private void Start()
    {
        _text = FindObjectOfType<TextMeshProUGUI>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Coin")
        {
            count++;
            Destroy(collision.gameObject);
            _text.text = count.ToString();
        }
    }
}
