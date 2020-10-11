using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    float score;
     TextMeshProUGUI scoreText;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;   
        scoreText = GetComponent<TextMeshProUGUI>();    
    }

    // Update is called once per frame
    void Update()
    {
        score = Time.time * 15;
        scoreText.text = score.ToString("0");
    }
}
