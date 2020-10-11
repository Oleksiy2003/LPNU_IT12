using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GetScore : MonoBehaviour
{
    // Start is called before the first frame update
    private TextMeshProUGUI maxScore;
    void Start()
    {
        maxScore = GetComponent<TextMeshProUGUI>();
        maxScore.text=PlayerPrefs.GetInt("Score").ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
