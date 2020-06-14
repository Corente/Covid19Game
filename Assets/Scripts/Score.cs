using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;
using System.IO;

public class Score : MonoBehaviour
{
    static public float BuildingNumber;
    static public float BuildingInfected;
    public Text ScoreText;
    public Text Timer;
    public float TimeLeft = 500;

    float tmp = 0;
    string filepath = Path.Combine(Directory.GetCurrentDirectory(), "HighScore.txt");

    // Update is called once per frame
    void Update()
    {
        if (TimeLeft <= 0f)
        {
            float s = (100f - ((BuildingInfected / BuildingNumber) * 100f));
            if (!File.Exists(filepath) || float.Parse(File.ReadAllText(filepath)) < s)
            {
                string HighScore = s.ToString("0");
                File.WriteAllText(filepath, HighScore);
            }
            
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true; 
            
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else
        {
            TimeLeft -= Time.deltaTime;
        }

        Timer.text = TimeLeft.ToString("0") + " s";

        tmp = ((BuildingInfected / BuildingNumber) * 100f);
        ScoreText.text = tmp.ToString("0") + " %";
    }
}
