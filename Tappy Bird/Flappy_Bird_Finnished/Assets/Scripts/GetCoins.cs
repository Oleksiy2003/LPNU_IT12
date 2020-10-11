using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GetCoins : MonoBehaviour
{
    // Start is called before the first frame update
    static int coins=0;
    private Text playerCoins;
    void Start()
    {
        playerCoins = GetComponent<Text>();
        coins += PlayerPrefs.GetInt("PlayerCoins");
        playerCoins.text = coins.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        




    }
}
