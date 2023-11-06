using Cinemachine;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private Player _player;
    private CinemachineVirtualCamera _camera;
    void Start()
    {
        _player = FindObjectOfType<Player>();
        _camera = FindObjectOfType<CinemachineVirtualCamera>();

        _camera.Follow = _player.transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
