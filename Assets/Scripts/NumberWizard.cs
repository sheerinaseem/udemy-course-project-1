using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {

    // Use this for initialization
    int max;
    int min;
    int guess;

    void Start () {
        StartGame();
	}

    void StartGame()
    {
        max = 1000;
        min = 1;
        guess = 500;

        print("============================");
        print("Hi, Welcome to Number Wizard.");
        print("Pick a number in your head but don't tell me.");

        print("The highest number you can pick is " + max + " and the lowest number you can pick is " + min);
        print("Press the up arrow key if it higher than 500 or press the down key if it lower than 500.");
        print("Up = Higher, Down = Lower, Enter = Equal");

        max = max + 1;
    }


    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            //print("Up key pressed.");
            min = guess;
            NextGuess();
        } else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            //print("Down key pressed.");
            max = guess;
            NextGuess();
        } else if (Input.GetKeyDown(KeyCode.Return))
        {
            print("I won!!");
            StartGame();
        }
    }

    void NextGuess()
    {
        guess = (max + min) / 2;
        print("Is the number higher or lower than " + guess);
        print("Up = Higher, Down = Lower, Enter = Equal");
    }
}
