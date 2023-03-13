using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Lobby : MonoBehaviour
{
    [SerializeField] private Button Play_button;
    [SerializeField] private Button quit_Button;

    private void Start()
    {
        Play_button.onClick.AddListener(PlayButton);
        quit_Button.onClick.AddListener(ExitGame);
    }

    public void PlayButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Quit The Game");
    }
}
