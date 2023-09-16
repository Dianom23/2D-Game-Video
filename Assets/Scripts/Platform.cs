using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public float leftPosition;
    public float rightPosition;
    public float speed;
    public float delay;
    void Start()
    {
        StartCoroutine(Move());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator Move()
    {
        while(true)
        {
            while (transform.position.x < rightPosition)
            {
                transform.Translate(Vector2.right * speed * Time.deltaTime);
                yield return null;
            }
            yield return new WaitForSeconds(delay);
            while (transform.position.x > leftPosition)
            {
                transform.Translate(Vector2.left * speed * Time.deltaTime);
                yield return null;
            }
            yield return new WaitForSeconds(delay);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            collision.transform.parent = transform;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            collision.transform.parent = null;
        }
    }
}
