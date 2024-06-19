using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public int score;
    public TMP_Text scoreText;

    void Update()
    {
        scoreText.text = score.ToString();
    }
}
