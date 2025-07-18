using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    public float JumpForce;

    private Rigidbody2D _rb;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _rb.linearVelocity = Vector2.zero;
            _rb.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
        }
    }
}
