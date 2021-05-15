using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using Assets;

public class GameController : MonoBehaviour
{

    [SerializeField]
    private TextMeshProUGUI player1Display;

    [SerializeField]
    private TextMeshProUGUI player2Display;

    private int player1Score;

    private int player2Score;

    private int wincondition = 3;

    private int server = 1;

    // Start is called before the first frame update
    void Start()
    {
        player1Score = 0;
        player2Score = 0;
        player1Display.text = player1Score.ToString();
        player2Display.text = player2Score.ToString();
    }

    public void UpdateScore(int player)
    {
        if (player == 1)
        {
            player1Score++;
            player1Display.text = player1Score.ToString();
            if (player1Score == wincondition)
            { 
                Winner.PlayerWins(1);
                SceneManager.LoadScene(0);
            }
            UpdateServer(2);
        }
        else if (player == 2)
        {
            player2Score++;
            player2Display.text = player2Score.ToString();
            if (player2Score == wincondition)
            {
                Winner.PlayerWins(2);
                SceneManager.LoadScene(0);
            }
            UpdateServer(1);
        }
    }

    public void UpdateServer(int player)
    {
        server = player ;
    }

    public int GetServer()
    {
        return GetServer();
    }
}
