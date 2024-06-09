using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform score;
    public Text scoreText;
    void Update()
    {
        scoreText.text = score.position.z.ToString("0");
    }
}
