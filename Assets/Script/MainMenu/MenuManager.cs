using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{

    
    [SerializeField] private GameObject playPanel;
    [SerializeField] private GameObject menuPanel;

    // Start is called before the first frame update
    void Start()
    {
        playPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void PlayButton()
    {
        playPanel.SetActive(true);
        menuPanel.SetActive(false);
    }


    public void GoToLevel1()
    {
        SceneManager.LoadScene(1);
    }
    public void GoToLevel2()
    {
        SceneManager.LoadScene(2);
    }



}
