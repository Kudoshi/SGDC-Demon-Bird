using UnityEngine;

public class Player : MonoBehaviour
{
    public float JumpForce;
    public ScoreUI ScoreUI;
    public EndGameUI EndGameUI;
    

    private Rigidbody2D rb;
    private int score;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.linearVelocity = Vector2.zero;
            rb.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Time.timeScale = 0f;
        EndGameUI.ShowEndGame(score);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Collectible"))
        {
            score++;
            ScoreUI.UpdateScore(score);
            Destroy(collision.gameObject);
        }
        
    }
}
