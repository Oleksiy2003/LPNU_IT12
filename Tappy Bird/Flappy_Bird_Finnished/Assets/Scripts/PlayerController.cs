using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    static int coins = 0;
    public float tapForce = 10;
    public float tiltSmooth = 5;
    public Vector3 startPos;
    public Text coinsText;


    Rigidbody2D rigidBody;
    Quaternion downRotation;
    Quaternion forwardRotation;

    void Start()
    {
        coins = 0;
        rigidBody = GetComponent<Rigidbody2D>();
        downRotation = Quaternion.Euler(0, 0, -15);
        forwardRotation = Quaternion.Euler(0, 0, 40);


    }

    // Update is called once per frame
    void Update()
    {
        coinsText.text = coins.ToString();


        if (Input.GetMouseButtonDown(0))
        {
            rigidBody.velocity = Vector2.zero;
            transform.rotation = forwardRotation;
            rigidBody.AddForce(Vector2.up * tapForce, ForceMode2D.Force);

        }

        transform.rotation = Quaternion.Lerp(transform.rotation, downRotation, tiltSmooth * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.D))
        {
            SceneManager.LoadScene(0);
        }
    }

     void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Coins")
        {
            coins++;
            PlayerPrefs.SetInt("PlayerCoins", coins);
            coins = PlayerPrefs.GetInt("PlayerCoins");
            PlayerPrefs.Save();
            Destroy(collision.gameObject);
        }
    }

}
