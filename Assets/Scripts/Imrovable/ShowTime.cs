using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowTime : MonoBehaviour
{
    //TODO: Improve this code by using a method
    //That only updates time each 1 second
    //Hint: You can use Coroutines or InvokeRepeating Methods to do so
    //Watch "Optimizing your code" video for more details

    private float currentPassedTime;    //Time passed since the begining of the game
    private Text timeText;              //Time text UI (Can be loaded from the game object)

    private void Awake()
    {
        currentPassedTime = 0;              //Initialize the time at the begining of the game
    }

    private void Update()
    { 
        currentPassedTime = currentPassedTime + Time.deltaTime;                 //Add the time between each frame to the current passed time
        GetComponent<Text>().text = "Time: " + (int)currentPassedTime;          //Show the current passed time as integer on the UI
    }
}
