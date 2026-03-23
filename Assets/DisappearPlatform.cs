using UnityEngine;

public class DisappearPlatform : MonoBehaviour
{
    public float timeOn = 2f;
    public float timeOff = 2f;

    private float timer;
    private bool active = true;
    private Collider2D col;
    private SpriteRenderer sr;

    void Start()
    {
        col = GetComponent<Collider2D>();
        sr = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (active && timer >= timeOn)
        {
            active = false;
            timer = 0f;
            col.enabled = false;
            sr.enabled = false;
        }
        else if (!active && timer >= timeOff)
        {
            active = true;
            timer = 0f;
            col.enabled = true;
            sr.enabled = true;
        }
    }
}