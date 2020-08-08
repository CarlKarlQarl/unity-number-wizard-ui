using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {

    [SerializeField] int min = 1;
    [SerializeField] int max = 1000;
    int guess = 500;

    // Start is called before the first frame update
    void Start() {
        StartGame();
    }

    // Update is called once per frame
    void Update() {
        
    }

    void StartGame() {
        max = max + 1;
        guess = (max + min) / 2;
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
    }
}