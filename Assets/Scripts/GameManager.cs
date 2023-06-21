using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI timerText;

    private float timer = 60;


    private void Start()
    {

    }

    private void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
            DisplayTime(timer);
        }
        else if (timer <= 1)
        {
            Debug.Log("Game Over!");
            Time.timeScale = 0;
        }
    }

    private void DisplayTime(float timeToDisplay)
    {
        float timer = Mathf.FloorToInt(timeToDisplay);
        timerText.text = "Time: " + timer;
    }

}
