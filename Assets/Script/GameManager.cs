using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    private UIManager uiManager;



    private int points;


    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        uiManager = FindObjectOfType<UIManager>();

        
    }

    // Update is called once per frame
    void Update()
    {
        
    
    }



    public void Pause()
    {
        uiManager.ShowPausePanel();
        Time.timeScale = 0;
        
    }

    public void Unpause()
    {
        uiManager.HidePausePanel();
        Time.timeScale = 1;

    }


    public void GetFeed()
    {
        points++;

    }

    public int GetPoints()
    {
        return points;
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GoToMenu()
    {
        SceneManager.LoadScene(0);
    }




}
