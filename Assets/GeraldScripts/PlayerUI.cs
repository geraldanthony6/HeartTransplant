using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI playerHealth;
    [SerializeField] private TextMeshProUGUI waveCount;
    [SerializeField]private TextMeshProUGUI endGameText;
    [SerializeField] private TextMeshProUGUI waveTimer;
    public GameObject endGameScreen;
    [SerializeField] private PlayerStats playerStats;
    [SerializeField] private WaveSpawner waveSpawner;
    
    // [SerializeField] private Image sr;
    // [SerializeField] private Sprite[] Health;
    // Start is called before the first frame update
    void Start()
    {
        if(!playerStats){
            if(GameObject.FindGameObjectWithTag("Player")){
                playerStats = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerStats>();
            } else
            {
                playerStats = GameObject.FindGameObjectWithTag("DogTrainer").GetComponent<PlayerStats>();
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

        playerHealth.text = "Player Health: " + playerStats._currPlayerHealth;
        waveCount.text = "Wave: " + waveSpawner.GetWaveCount();
        waveTimer.text = "Next Wave: " + (int)waveSpawner.GetWaveTimer();
        endGameText.text = "You Survived " + waveSpawner.GetWaveCount() + " Waves of Emotions";

        if(playerStats._currPlayerHealth <= 0){
            endGameScreen.SetActive(true);
        }
        // checkHealth();
    }

    public void SetPlayerStats(PlayerStats stats)
    {
        playerStats = stats;
    }
    // public void checkHealth()
    // {
    //     if (playerStats._currPlayerHealth >= playerStats._maxHealth)
    //     {
    //         sr.sprite = Health[0];

    //     }
    //     if (playerStats._currPlayerHealth <= 75 && playerStats._currPlayerHealth >= 50)
    //     {
    //         sr.sprite = Health[1];

    //     }
    //     if (playerStats._currPlayerHealth <= 50 && playerStats._currPlayerHealth >= 25)
    //     {
    //         sr.sprite = Health[2];

    //     }
    //     if (playerStats._currPlayerHealth <= 25 && playerStats._currPlayerHealth >= 10)
    //     {
    //         sr.sprite = Health[3];
    //     }
    //     if (playerStats._currPlayerHealth <= 10 && playerStats._currPlayerHealth >= 1)
    //     {
    //         sr.sprite = Health[4];
    //     }
    //     if (playerStats._currPlayerHealth <= 0) { }
    //     sr.sprite = Health[5];
    // }
}
