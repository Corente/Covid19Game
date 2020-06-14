using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.IO;

public class GetScore : MonoBehaviour
{
   public Text t;
   
    string filepath = Path.Combine(Directory.GetCurrentDirectory(), "HighScore.txt");

    void Start()
   {
       if (File.Exists(filepath))
       {
           t.text = File.ReadAllText(filepath);
       }
   }
}
