using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Coins : MonoBehaviour
{
    Text playerCoins;
    public static int AllCoins;
    // Start is called before the first frame update
    void Start()
    {

        playerCoins = GetComponent<Text>();
        AllCoins += PlayerPrefs.GetInt("PlayerCoins");
    }

    // Update is called once per frame
    void Update()
    {
        
        PlayerPrefs.SetInt("PlayerCoins", AllCoins);
        playerCoins.text = PlayerPrefs.GetInt("PlayerCoins").ToString();



        if (Input.GetKeyDown(KeyCode.D))
        {
            
            SceneManager.LoadScene(1);
        }
    }
}
