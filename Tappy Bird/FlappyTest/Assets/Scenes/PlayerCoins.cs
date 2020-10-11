using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerCoins : MonoBehaviour
{
    // Start is called before the first frame update
    Text text;
    static int coins = 0;
    void Start()
    {
        coins = 0;
        text = GetComponent<Text>();
    }
    // Update is called once per frame
    void Update()
    {
        text.text = coins.ToString();
            
        PlayerPrefs.SetInt("PlayerCoins", coins);
        if (Input.GetKeyDown(KeyCode.D))
        {
         
            SceneManager.LoadScene(0);
              
        }

       
    }
    public void AddCoin()
    {
        coins++;
        

    }
}
