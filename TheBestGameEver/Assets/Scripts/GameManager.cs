using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Menu;
    public GameObject win;
    public GameObject fail;
    private GameObject[] coins;
    void Start()
    {
        CoinCollector.onCollect.AddListener(FindRemainCoins);
        Spikes.onDestroy.AddListener(GameOver);
        coins = GameObject.FindGameObjectsWithTag("Coin");
    }
    public void GameOver()
    {
        Time.timeScale = 0;
        Menu.SetActive(true);
        fail.SetActive(true);
    }
    public void Win()
    {
        Time.timeScale = 0;
        Menu.SetActive(true);
        win.SetActive(true);
    }
    void FindRemainCoins()
    {
        coins = GameObject.FindGameObjectsWithTag("Coin");
        Debug.Log(coins.Length);
        if (coins.Length - 1 == 0)
        {
            Win();
        }
    }

}
