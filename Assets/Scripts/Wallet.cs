using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Wallet : MonoBehaviour
{
    public int count;
    [SerializeField] private TextMeshProUGUI _text;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Coin")
        {
            count++;
            _text.text = count.ToString();
            Destroy(collision.gameObject);
        }
    }
}
