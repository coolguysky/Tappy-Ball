using UnityEngine;

public class BallController : MonoBehaviour
{
    private Rigidbody2D rb;
    public float upForce;
    private bool started;
    private bool gameOver;
    public float rotation;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        started = false;
        gameOver = false;
    }
    private void Update()
    {
        if (!started)
        {
            if (Input.GetMouseButtonDown(0))
            {
                started = true;
                rb.isKinematic = false;
                GameManager.instance.GameStart();
            }
        }
        else if (started && !gameOver)
        {
            transform.Rotate(0, 0, rotation);
            if (Input.GetMouseButtonDown(0))
            {
                rb.velocity = Vector2.zero;
                rb.AddForce(new Vector2(0, upForce));
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Pipe") && !gameOver)
        {
            gameOver = true;
            GameManager.instance.GameOver();
            GetComponent<Animator>().Play("BallAnimation");
        }
        if (collision.CompareTag("ScoreChecker") && !gameOver)
        {
            ScoreManager.instance.IncremenetScore();
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameOver = true;
        GameManager.instance.GameOver();
        GetComponent<Animator>().Play("BallAnimation");
    }
}
