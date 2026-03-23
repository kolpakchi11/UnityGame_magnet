using UnityEngine;

public class Glow : MonoBehaviour
{
    private SpriteRenderer sr;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        float intensity = (Mathf.Sin(Time.time * 3f) + 1f) / 2f;

        sr.color = Color.Lerp(
            new Color(1f, 1f, 1f),
            new Color(0.5f, 1f, 1f),
            intensity
        );
    }
}