using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.Advertisements;
using UnityEngine;

public class GameControl : MonoBehaviour
{
    public bool doubleCoins;
    public GameObject monetScore;
    public int collectedCoins=0;
    public Animator scoreEffect;
    public GameObject HomeFade;
    public GameObject monetCollect;
    public GameObject OnGameOverUI;
    public  int coins = 0;
    public static int AllCoins = 0;
    public  int score=0;
    public static GameControl instance;
    public bool gameOver = false;
    public float scrollSpeed = -2.5f;
    public GameObject[] Threat;
    public GameObject[] Threat2;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI coinsText;
    public TextMeshProUGUI GameOver_scoreText;
    public Vector3 monetInst = new Vector3(0, 0, 0);

    Vector3 randPos;
    Vector3 randPos2;
    int rand;
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }   
        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        doubleCoins = false;
        collectedCoins = 0;
        coins = 0;   
        CreateThreat();
        HomeFade.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        coinsText.text = coins.ToString();
        scoreText.text = score.ToString();    
      
            if ( Input.GetKeyDown(KeyCode.D))
            {           
            SceneManager.LoadScene(0);
            }

        Debug.Log(coins);
    }


   
   public void BirdDied()
    {      
        gameOver = true;      
        OnGameOverUI.SetActive(true);
        

    }
    public void BirdCoins()
    {

        if (gameOver == false)
            coins++;
        
        
            PlayerPrefs.SetInt("Coins", PlayerPrefs.GetInt("Coins") + 1);
        
        
         
        
    }
    public void BirdScored()
    {
        scoreEffect.Play("ScoreText");
        score++;
        if (PlayerPrefs.GetInt("Score") < score)
            PlayerPrefs.SetInt("Score", score);
    }
    public void CreateThreat()
    {
        int rand = Random.Range(0, 3);
        randPos = new Vector3(9f, Random.Range(1.8f, -0.6f), 0);
        if (score > 5) rand = Random.Range(4, 7);
        if (rand == 6)
            randPos = new Vector3(9f, Random.Range(3.7f, 3.70f), 0);
        Instantiate(Threat[rand], randPos, Quaternion.identity);
    }
    public void scalePlusScore()
    {
        scoreText.rectTransform.localScale = new Vector3(scoreText.rectTransform.localScale.x + 1f, scoreText.rectTransform.localScale.y + 1f, 0);

    }
    public void scaleMinusScore()
    {
        scoreText.rectTransform.localScale = new Vector3(scoreText.rectTransform.localScale.x - 1f, scoreText.rectTransform.localScale.y - 1f, 0);

        
    }
    
}
