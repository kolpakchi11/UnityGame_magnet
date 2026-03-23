using UnityEngine;

public class MovePlatform : MonoBehaviour
{
    public float speed = 2f;
    public float distance = 2f;
    public bool horizontal = true;

    private Vector3 startPos;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        float movement = Mathf.Sin(Time.time * speed) * distance;

        if (horizontal)
            transform.position = startPos + Vector3.right * movement;
        else
            transform.position = startPos + Vector3.up * movement;
    }
}