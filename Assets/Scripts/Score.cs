using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;

public class Score : MonoBehaviour
{
    GameObject ScoreDisplay;
   public int score = 0;
    int randomNumber = 0;
  public void addOne()
    {
        score++;
        Console.WriteLine(score);
    }


    private void Update()
    { 
        
        if (score == 10)
        {
            if (randomNumber >= 0 && randomNumber <= 3)
            {
                GameObject childObject = ScoreDisplay.transform.GetChild(randomNumber).gameObject;
                childObject.SetActive(true);
            }

        }
    }
     void Start()
    {

        // Generates a number that is exactly 0, 1, 2, or 3
       randomNumber = UnityEngine.Random.Range(0, 4);

        // Assuming ScoreDisplay is your parent GameObject
        foreach (Transform child in ScoreDisplay.transform)
        {
            // Access the GameObject of the child
            GameObject childObject = child.gameObject;

            // Your code here (e.g., childObject.SetActive(false);)
            childObject.SetActive(false);
        }

    }




}
