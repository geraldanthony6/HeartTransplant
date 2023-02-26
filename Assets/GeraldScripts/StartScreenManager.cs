using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartScreenManager : MonoBehaviour
{
    [SerializeField]private Button[] screenButtons;
    [SerializeField]private AudioSource startMenuMusic;
    // Start is called before the first frame update
    void Start()
    {
        screenButtons[0].onClick.AddListener(LoadGame);    
        screenButtons[1].onClick.AddListener(LoadControls);
        screenButtons[2].onClick.AddListener(ExitGame);
        startMenuMusic.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void LoadGame(){
        SceneManager.LoadScene("Gerald Test Scene");
    }

    void LoadControls(){
        SceneManager.LoadScene("ControlScreen");
    }

    void ExitGame(){
        Debug.Log("Close da game");
        Application.Quit();
    }

}
