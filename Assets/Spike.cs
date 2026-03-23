using UnityEngine;

public class Spike : MonoBehaviour
{
    public Transform spawnPoint;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            col.transform.position = spawnPoint.position;

            Rigidbody2D rb = col.GetComponent<Rigidbody2D>();
            rb.linearVelocity = Vector2.zero;
        }
    }
}