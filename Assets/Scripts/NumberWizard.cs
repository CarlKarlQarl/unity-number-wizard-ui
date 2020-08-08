using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour {

    [SerializeField] int min;
    [SerializeField] int max;
    [SerializeField] TextMeshProUGUI guessText;
    int guess;

    // Start is called before the first frame update
    void Start() {
        StartGame();
    }

    // Update is called once per frame
    void Update() {
        
    }

    void StartGame() {
        guess = (max + min) / 2;
        guessText.text = guess.ToString();
        max = max + 1;
    }

    public void OnPressHigher(){
        min = guess;
        NextGuess();
    }
    public void OnPressLower(){
        max = guess;
        NextGuess();
    }

    void NextGuess() {
        guess = (max + min) / 2;
        guessText.text = guess.ToString();
    }
}