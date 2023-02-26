using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ControlScreen : MonoBehaviour
{
    [SerializeField]private Button returnHomeBtn;
     // Start is called before the first frame update
    void Start()
    {
        returnHomeBtn.onClick.AddListener(ReturnHome);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ReturnHome(){
        SceneManager.LoadScene("StartScreen");
    }
}
