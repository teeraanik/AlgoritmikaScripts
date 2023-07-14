using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public int minutes;
    public float seconds;
    public TextMeshProUGUI timer;

    void Update()
    {
        seconds -= Time.deltaTime;

        if (seconds < 0)
        {
            if (minutes > 0)
            {
                minutes--;
                seconds += 60;

            }
            else
            {
                int sceneIndex = SceneManager.GetActiveScene().buildIndex;
                SceneManager.LoadScene(sceneIndex);
            }
        }

        timer.text = minutes.ToString() +":"+ ((int)seconds).ToString();

        
    }
}
