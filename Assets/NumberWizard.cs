using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour {

    int max;
    int min;
    int guess;
    int maxGuessesAllowed = 10;

    public Text TEXT;

	// Use this for initialization
	void Start () {
        StartGame();
	}
    
    void StartGame() {
        max = 1000;
        min = 1;
        
        guess = Random.Range(min, max+1);
        TEXT.text = guess.ToString();
    }
    
    public void GuessHigher(){
        min = guess;
        NextGuess();
    }
    
    public void GuessLower(){
        max = guess;
        NextGuess();
    }

    
    void NextGuess() {
        // guess = (max + min) / 2;
        guess = Random.Range(min, max+1);
        TEXT.text = guess.ToString();
        maxGuessesAllowed = maxGuessesAllowed - 1;
        if (maxGuessesAllowed <= 0){
            SceneManager.LoadScene("Win");
        }
    }
}
