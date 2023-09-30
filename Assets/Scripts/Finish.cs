using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    private int _coinsCount;
    private Wallet _wallet;


    void Start()
    {
        _coinsCount = GameObject.FindGameObjectsWithTag("Coin").Length;
        _wallet = FindAnyObjectByType<Wallet>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if (_wallet.count == _coinsCount)
            {
                print("Finish");
            }
        }
    }
}
