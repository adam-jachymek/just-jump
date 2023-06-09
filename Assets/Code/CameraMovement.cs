using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] float speed = 0.5f;
    [SerializeField] private Rigidbody2D rigidBody;

    private Player player;

    void Start()
    {
        player = GameObject.Find("Player").GetComponent<Player>();
    }

    void Update()
    {
        movement();
    }

    public void movement()
    {
        if (player.started) { rigidBody.velocity = new Vector2(0, speed); }
    }
}
