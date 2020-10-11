using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GetCoi : MonoBehaviour
{
    // Start is called before the first frame update
    TextMeshProUGUI PlayerMoney;
    
   
    void Start()
    {

        PlayerMoney = GetComponent<TextMeshProUGUI>();
        PlayerMoney.text = PlayerPrefs.GetInt("Coins").ToString();





    }

    // Update is called once per frame
    void Update()
    {
        
        


    }
}
