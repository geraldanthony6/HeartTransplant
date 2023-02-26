using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]private PlayerStats playerStats;
    [SerializeField]private PlayerUI playerUI;
    [SerializeField]private SpriteRenderer spriteRenderer;
    [SerializeField]private Sprite[] playerSprites;
    private bool movedThroughDoor1 = false;

    // Start is called before the first frame update
    void Start()
    {
        //spriteRenderer = GetComponent<SpriteRenderer>();
        playerUI = GameObject.FindGameObjectWithTag("PlayerUI").GetComponent<PlayerUI>();
        playerStats = GetComponent<PlayerStats>();
        playerUI.SetPlayerStats(playerStats);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * playerStats.maxSpeed * Time.deltaTime * Input.GetAxisRaw("Horizontal"));
        transform.Translate(Vector2.up * playerStats.maxSpeed * Time.deltaTime * Input.GetAxisRaw("Vertical"));
        Debug.Log(Input.GetAxisRaw("Horizontal") );
        if(Input.GetAxisRaw("Horizontal") == 1){
            
            spriteRenderer.sprite = playerSprites[1];
        } 

        if(Input.GetAxisRaw("Horizontal") == -1){
            spriteRenderer.sprite = playerSprites[3];
        }

        if(Input.GetAxisRaw("Vertical" ) == 1){
            spriteRenderer.sprite = playerSprites[2];
        }

        if(Input.GetAxisRaw("Vertical" ) == -1){
            spriteRenderer.sprite = playerSprites[0];
        }

        

        
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("Door1")){
            movedThroughDoor1 = true;
            Debug.Log("Go to next room");
        }
    }

    public bool GetMovedThroughtDoor1(){
        return movedThroughDoor1;
    }
}
