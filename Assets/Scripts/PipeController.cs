using UnityEngine;

public class PipeController : MonoBehaviour
{
    public float speed;
    public float upDownSpeed;
    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        MovePipe();
        InvokeRepeating(nameof(SwitchUpDown), 0.1f, 1f);
    }
    private void SwitchUpDown()
    {
        upDownSpeed = -upDownSpeed;
        rb.velocity = new Vector2(-speed, upDownSpeed);
    }
    private void MovePipe()
    {
        rb.velocity = new Vector2(-speed, upDownSpeed);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("PipeRemover"))
        {
            Destroy(gameObject);
        }
    }
}
