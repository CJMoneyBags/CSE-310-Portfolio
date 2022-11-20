using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public AudioClip playerDamage;
    AudioSource playerAS;

    public float fullHealth;
    float currentHealth;

    public string endText = "You Win!";
    public Image deathScreen;
    public CanvasGroup endCG;
    public Text endGameUIText;
    public Image healthSlider;


    private void Start()
    {
        currentHealth = fullHealth;
        playerAS = GetComponent<AudioSource>();
        healthSlider.fillAmount = 0f;
    }
    public void MakeDead()
    {
        endText = "You Died";
        Destroy(gameObject);
        EndGame();
        deathScreen.color = Color.white;
    }

    public void AddDamage(float damage)
    {
        if(damage <= 0)
        {
            return;

        }
        currentHealth -= damage;

        healthSlider.fillAmount = 1 - currentHealth / fullHealth;

        playerAS.PlayOneShot(playerDamage);

        if(currentHealth <= 0)
        {
            MakeDead();
        }
    }

    public void EndGame()
    {
        endGameUIText.text = endText;
        endCG.alpha = 1;
        print(endText);
    }
}
