using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using TMPro;
using UnityEngine;

public class NumberWizards : MonoBehaviour
{

    [SerializeField] int max_guess;
    [SerializeField] int min_guess;
    [SerializeField] TextMeshProUGUI guessText;

    int guess;


    // Start is called before the first frame update
    void Start()
    {
        NextGuess();

    }


    public void PressHigher()
    {
        if(min_guess<1000)
        {
            min_guess = guess + 1;
            NextGuess();
        }
    }

    public void PressLower()
    {
        max_guess = guess - 1;
        NextGuess();

    }




    public void NextGuess()
    {
        guess = Random.Range(min_guess, max_guess );
        guessText.text = guess.ToString();

    }

}
