using UnityEngine.UI;
using UnityEngine;

public class PlayerScore : MonoBehaviour
{
    int score;
    [SerializeField] Text scoreText;

    private void Start()
    {
       Fruit.OnScoredChanged += Instance_OnScoredChanged;
    }

    private void Instance_OnScoredChanged(object sender, System.EventArgs e)
    {
        score++;
        scoreText.text = score.ToString();
    }

    private void OnDisable()
    {
        Fruit.OnScoredChanged -= Instance_OnScoredChanged;
    }
}
