using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class NumberWizard : MonoBehaviour {

    public Text myGuess;


    int min = 0;
    int max = 0;
    int guess = 0;
    int maxGuess = 0;

    // Use this for initialization
    void Start () {

        StartGame();
	}
	
	// Update is called once per frame
	void Update () {
		
        if (Input.GetKeyDown("up"))
        {
           
            min = guess + 1;
            NextGuess();
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
       
            max = guess;
            NextGuess();
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {

            StartGame();
        }
    }

    void StartGame ()
    {
  
        min = 1;
        max = 1000;
        //guess = 500;

        NextGuess();
    }

    void NextGuess()
    {

        if (maxGuess == 5)

        {
            SceneManager.LoadScene("Win");
        }

        else
        {
            guess = Random.Range(min, (max + 1));
            myGuess.text = "The guessed number is: " + guess;
        }

       

    }

    public void GuessHigher()
    {
        min = guess + 1;
        NextGuess();
        maxGuess++;
    }

    public void GuessLower()
    {
        max = guess;
        NextGuess();
        maxGuess++;
    }


}
