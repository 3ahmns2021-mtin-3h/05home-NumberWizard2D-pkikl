using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour
{
    public TextMeshProUGUI visibleGuess;
    public GameObject buttonLower;
    public GameObject buttonHigher;
    public GameObject buttonFinished;
    public GameObject buttonRestart;

    int min = 1;
    int max = 200;
    int guess;

    // Start is called before the first frame update
    void Start()
    {
        Restart();
    }

    private void NextGuess()
    {

        guess = (min + max) / 2;
        visibleGuess.text = guess.ToString();

    }

    public void LowerNumber()
    {
        max = guess - 1;
        NextGuess();
    }
    
    public void HigherNumber()
    {
        min = guess + 1;
        NextGuess();
    }

    public void CorrectNumber()
    {

        buttonHigher.SetActive(false);
        buttonLower.SetActive(false);
        buttonFinished.SetActive(false);
        buttonRestart.SetActive(true);

    }

    public void Restart()
    {

        min = 1;
        max = 200;
        NextGuess();
        buttonHigher.SetActive(true);
        buttonLower.SetActive(true);
        buttonFinished.SetActive(true);
        buttonRestart.SetActive(false);

    }
}