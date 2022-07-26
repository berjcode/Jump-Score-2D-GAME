using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public bool StopGameControl;
    public static GameController Instance { get; private set;}

    [SerializeField] private TextMeshProUGUI textScore;
    public int Score 
    {
        get => _score;
        set
         {
            if (value>_score)
            {
                _score = value;
                textScore.SetText(_score.ToString());
            }

         }
    }
    public int _score;
    private void Awake()
    {
        Instance = this;
    }
  
    public void GameOver()
    {
        Debug.Log("Game Over");
        Time.timeScale = 0;
        

    }


    public void StopGame()
    {
        if(StopGameControl == true)
        { 
            Time.timeScale = 1f;
            StopGameControl= false;
        }
        else
        {
            Time.timeScale = 0f;
            StopGameControl= true;
        }
      
    }


}



