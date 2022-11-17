using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInventory : MonoBehaviour
{

    public Text coinText;
    int Coins = 0;

    private void Start()
    {
        coinText.text = Coins.ToString();
    }

    public void AddCoins()
    {
        Coins++;
        coinText.text = Coins.ToString();
        //print(Coins);
    }
}
