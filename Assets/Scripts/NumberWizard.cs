using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    [SerializeField] int max;
    [SerializeField] int min;
    [SerializeField] TextMeshProUGUI guessText;

    int guess;

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        GuessNext();
    }

    void GuessNext()
    {
        guess = Random.Range(min, max);
        guessText.text = guess.ToString();
    }

    public void OnPressHigher()
    {
        min = guess;
        min++;
        GuessNext();
    }

    public void OnPressLower()
    {
        max = guess;
        max--;
        GuessNext();
    }
}
