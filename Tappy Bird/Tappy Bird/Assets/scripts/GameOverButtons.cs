using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.Advertisements;

public class GameOverButtons : MonoBehaviour
{
    // Start is called before the first frame update
     IEnumerator wait()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(0);
    }
    private void OnMouseDown()
    {
        gameObject.transform.localScale = new Vector3(transform.localScale.x-0.2f, transform.localScale.y - 0.2f, 0*Time.deltaTime);
       
    }
    private void OnMouseUp()
    {
        gameObject.transform.localScale = new Vector3(transform.localScale.x + 0.2f, transform.localScale.y + 0.2f, 0);
        switch (gameObject.name)
        {
            case "Replay":
                SceneManager.LoadScene(1);
                break;
            case "Home":
                GameControl.instance.HomeFade.SetActive(true);
                StartCoroutine(wait());
                break;
            case "YouTube":
                if (Advertisement.IsReady("rewardedVideo"))
                {
                    Advertisement.Show();
                    SceneManager.LoadScene(0);
                    if (Advertisement.isShowing == true)
                    {
                        //GameControl.instance.coins *= 2;
                       //* PlayerPrefs.SetInt("Coins", PlayerPrefs.GetInt("Coins") + GameControl.instance.coins);*//*
                    }
                }
                break;
            case "TapToPlay":
                SceneManager.LoadScene(1); 
                break;
        }
    }
}
