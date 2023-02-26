using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    private bool isPaused;
    [SerializeField]private GameObject pauseMenu;
    [SerializeField]private GameObject controlsMenu;
    [SerializeField]private Button[] pauseBtns;
    [SerializeField]private Button[] endButtons;
    // Start is called before the first frame update
    void Start()
    {
        pauseBtns[0].onClick.AddListener(Resume);
        pauseBtns[1].onClick.AddListener(ShowControls);
        pauseBtns[2].onClick.AddListener(ReturnToHome);
        pauseBtns[3].onClick.AddListener(Quit);
        pauseBtns[4].onClick.AddListener(CloseControls);

        endButtons[0].onClick.AddListener(ReturnToHome);
        endButtons[1].onClick.AddListener(Quit);
    }

    // Update is called once per frame
    void Update()
    {
        if(!isPaused && (Input.GetKeyDown(KeyCode.P) || Input.GetKeyDown(KeyCode.Escape))){
            isPaused = true;
            Time.timeScale = 0;
            pauseMenu.SetActive(true); 
        } else if(isPaused && (Input.GetKeyDown(KeyCode.P) || Input.GetKeyDown(KeyCode.Escape))){
            isPaused = false;
            Time.timeScale = 1;
            pauseMenu.SetActive(false);
            controlsMenu.SetActive(false);
        }
    }

    void Resume(){
        isPaused = false;
        Time.timeScale = 1;
        pauseMenu.SetActive(false);
    }

    void ShowControls(){
        controlsMenu.SetActive(true);
    }

    void CloseControls(){
        controlsMenu.SetActive(false);
    }

    public void ReturnToHome(){
        SceneManager.LoadScene("StartScreen");
    }

    public void RestartGame(){
        SceneManager.LoadScene("Gerald Test Scene");
    }

    public void Quit(){
        Application.Quit();
    }
}
