using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Events;
public class CoinCollector : MonoBehaviour
{
    private int amount;
    public TextMeshProUGUI rateText;

    public static readonly UnityEvent onCollect = new UnityEvent();

    public void UpdateScore()
    {
        amount++;
        rateText.text = "Score: " + amount.ToString() + " Coins";
        onCollect.Invoke();
    }


}
