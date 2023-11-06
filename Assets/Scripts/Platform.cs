using UnityEngine;

public class Platform : MonoBehaviour
{
    [SerializeField] private float _speed = 1;
    private float _startPositionX;
    [SerializeField] private float _lenght = 5;
    // Start is called before the first frame update
    void Start()
    {
        _startPositionX = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        float offset = Mathf.PingPong(Time.time * _speed, _lenght);
        Vector2 newPosition = new Vector2(_startPositionX + offset, transform.position.y);
        transform.position = newPosition;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Player")
        {
            collision.transform.parent = transform;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.tag == "Player")
        {
            collision.transform.parent = null;
        }
    }
}
