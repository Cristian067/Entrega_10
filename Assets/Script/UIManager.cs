using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    private GameManager gameManager;

    [SerializeField] private GameObject pausePanel;
    [SerializeField] private GameObject gameOverPanel;


    [SerializeField] private TextMeshProUGUI pointsText;
    [SerializeField] private TextMeshProUGUI pointsInGameText;





    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        pausePanel.SetActive(false);
        gameOverPanel.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        pointsInGameText.text = $"Points: {gameManager.GetPoints()}";
       
    }
    

    public void ShowPausePanel()
    {
        pausePanel.SetActive(true);
        

    }

    public void HidePausePanel()
    {
        pausePanel.SetActive(false);


    }

    public void ShowGameOverPanel()
    {
        gameOverPanel.SetActive(true) ;
        pointsText.text = $"Animales alimentados: {gameManager.GetPoints()} ";
    }


    



}
