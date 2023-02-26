using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerUI : MonoBehaviour
{
    [SerializeField]private TextMeshProUGUI playerHealth;
    [SerializeField]private PlayerStats playerStats;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        playerHealth.text = "Player Health: " + playerStats._currPlayerHealth;
    }

    public void SetPlayerStats(PlayerStats stats){
        playerStats = stats;
    }
}
