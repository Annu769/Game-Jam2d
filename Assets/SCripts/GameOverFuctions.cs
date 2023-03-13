using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameOverFuctions : MonoBehaviour
{

    public static GameOverFuctions Instance;
    [SerializeField] private GameObject gameOverPanel;
    [SerializeField] private GameObject pausePanel;
    [SerializeField] private Button restart_Button;
    [SerializeField] private Button lobby_Button;
    [SerializeField] private Button resume_Button;
    [SerializeField] private  Button quit_Button;
    private static bool isGamePause = false;
    private void Awake()
    {
        Instance = this;
    }
    void Start()
    {
        restart_Button.onClick.AddListener(RestartGame);
        lobby_Button.onClick.AddListener(GoToLobby);
        quit_Button.onClick.AddListener(ExitGame);
        resume_Button.onClick.AddListener(ClosePausePanel);
        gameOverPanel.SetActive(false);
        pausePanel.SetActive(false);
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if (isGamePause)

                ClosePausePanel();

            else

                PauseTheGame();
        }
            
            
        
       
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void GoToLobby()
    {
        SceneManager.LoadScene(0);
    }    
    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Exit The Game");
    }
    public void ClosePausePanel()
    {
        pausePanel.SetActive(false);
        Time.timeScale = 1f;
        isGamePause = false;
    }
    public void PauseTheGame()
    {
        pausePanel.SetActive(true);
        Time.timeScale = 0f;
        isGamePause = true;
    }
    public void GameIsOver()
    {
        gameOverPanel.SetActive(true);
        Time.timeScale = 0f;
        isGamePause = true;
    }
}
