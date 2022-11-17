using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{
    bool collected = false;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player" && !collected)
        {
            other.gameObject.GetComponent<PlayerInventory>().AddCoins();
            Destroy(gameObject.transform.root.gameObject);
            collected = true;
        }
    }
}
