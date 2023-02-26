using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerUI : MonoBehaviour
{
    [SerializeField]private TextMeshProUGUI playerHealth;
    [SerializeField]private TextMeshProUGUI waveCount;
    [SerializeField]private TextMeshProUGUI waveTimer;
    [SerializeField]private PlayerStats playerStats;
    [SerializeField]private WaveSpawner waveSpawner;
    [SerializeField] private Image sr;
    [SerializeField] private Sprite[] Health;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        playerHealth.text = "Player Health: " + playerStats._currPlayerHealth;
        waveCount.text = "Wave: " + waveSpawner.GetWaveCount();
        waveTimer.text = "Next Wave: " + (int)waveSpawner.GetWaveTimer();
        checkHealth();
    }

    public void SetPlayerStats(PlayerStats stats){
        playerStats = stats;
    }
      public void checkHealth()
    {
        if (playerStats._currPlayerHealth >= playerStats._maxHealth)
        {
            sr.sprite = Health[0];

        }
        if (playerStats._currPlayerHealth <= 75 && playerStats._currPlayerHealth >= 50)
        {
            sr.sprite = Health[2];

        }
        if (playerStats._currPlayerHealth <= 50 && playerStats._currPlayerHealth >= 25)
        {
            sr.sprite = Health[3];

        }
        if (playerStats._currPlayerHealth <= 25 && playerStats._currPlayerHealth >= 10)
        {
            sr.sprite = Health[4];
        }
         if (playerStats._currPlayerHealth <= 10 && playerStats._currPlayerHealth >= 1)
        {
            sr.sprite = Health[5];
        }
    }
}
