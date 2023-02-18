using UnityEngine.SceneManagement;
using UnityEngine;

public class GameOver : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
        Bomb.OnGameOver += Bomb_OnGameOver;
    }

    private void Bomb_OnGameOver(object sender, System.EventArgs e)
    {
        gameObject.SetActive(true);
        Time.timeScale = 0;
    }

    public void LoadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        gameObject.SetActive(false);
        Time.timeScale = 1;
    }

    private void OnDisable()
    {
        Bomb.OnGameOver -= Bomb_OnGameOver;
    }
}
