using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Wallet : MonoBehaviour
{
    public int count;
    [SerializeField] private TextMeshProUGUI _text;

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
