using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerUI : MonoBehaviour
{
    [SerializeField]private TextMeshProUGUI playerHealth;
    [SerializeField]private TextMeshProUGUI waveCount;
    [SerializeField]private TextMeshProUGUI waveTimer;
    [SerializeField]private PlayerStats playerStats;
    [SerializeField]private WaveSpawner waveSpawner;
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
    }

    public void SetPlayerStats(PlayerStats stats){
        playerStats = stats;
    }
    
}
