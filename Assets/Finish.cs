using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLevel : MonoBehaviour
{
    public GameObject winText; // сюда закинешь Text (YOU WIN)
    public float delay = 2f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("WIN!");

            // показываем текст
            winText.SetActive(true);

            // загружаем уровень через время
            Invoke("LoadNextLevel", delay);
        }
    }

    void LoadNextLevel()
    {
        int nextScene = SceneManager.GetActiveScene().buildIndex + 1;
        SceneManager.LoadScene(nextScene);
    }
}