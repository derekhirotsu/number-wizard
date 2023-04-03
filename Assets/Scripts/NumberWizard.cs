using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour {
  [SerializeField] int max;
  [SerializeField] int min;
  [SerializeField] TextMeshProUGUI guessText;
  int guess;

  void Start () {
    StartGame();
	}

  void StartGame () {
    max = max + 1; // Accomodates Random.Range upper limit being exclusive.
    NextGuess();
  }

  void NextGuess () {
    if (min < max) {
      guess = Random.Range(min, max);
      guessText.text = guess.ToString();
    } else {
      min = guess;
    }
  }

  public void OnPressHigher() {
    min = guess + 1;
    NextGuess();
  }

  public void OnPressLower () {
    max = guess;
    NextGuess();
  }
}
