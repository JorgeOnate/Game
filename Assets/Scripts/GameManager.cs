using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    
    
    [SerializeField]private TextMeshProUGUI word;
    [SerializeField]private TextMeshProUGUI letters;
    [SerializeField]private TextMeshProUGUI lives;
    [SerializeField]private TextMeshProUGUI attempts;

    private string letter;
    
    private string currentScene;
    int cont =0;
    private Hangman hangman;
    void Start()
    {
        currentScene = SceneManager.GetActiveScene().name;
        //background = gameObject.GetComponent<>();
        if (currentScene.Equals("Level1.2"))
        {
            cont = 1;
        }
        if (currentScene.Equals("Level2.2"))
        {
            cont = 2;
        }
        if (currentScene.Equals("Level3.2"))
        {
            cont = 3;
        }

        hangman = new Hangman(cont);
        
        word = GameObject.FindWithTag("Word").GetComponent<TextMeshProUGUI>();
        letters = GameObject.FindWithTag("Letters").GetComponent<TextMeshProUGUI>();
        lives = GameObject.FindWithTag("Lives").GetComponent<TextMeshProUGUI>();
        attempts = GameObject.FindWithTag("Attempts").GetComponent<TextMeshProUGUI>();

        word.text = hangman.convertWord();
        lives.text = hangman.Lives.ToString();
        attempts.text = hangman.Attempts.ToString();
        letters.text = "";
    }

    void KeyPress(string letter)
    {
        if (hangman.Word.Contains(letter))
        {
            hangman.GuessWords(char.Parse(letter));
            word.text = hangman.guessWord;
        }
        else
        {
            hangman.Letters += letter + " ";
            letters.text = hangman.Letters;

            if (hangman.Attempts != 0)
            {
                hangman.Attempts--;
                attempts.text = hangman.Attempts.ToString();
            }
            else
            {
                hangman.Lives--;
                lives.text = hangman.Lives.ToString();
                hangman.SelectRandomWord(cont);
                hangman.Attempts = 7;
                hangman.Letters = "";
                word.text = hangman.convertWord();
                word.text = hangman.guessWord;
                lives.text = hangman.Lives.ToString();
                attempts.text = hangman.Attempts.ToString();
                letters.text = "";
            }

            if (hangman.Lives == 0)
            {
                SceneManager.LoadScene(1);
            }
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            letter = "a";
            KeyPress(letter);
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            letter = "b";
            KeyPress(letter);
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            letter = "c";
            KeyPress(letter);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            letter = "d";
            KeyPress(letter);
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            letter = "e";
            KeyPress(letter);
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            letter = "f";
            KeyPress(letter);
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            letter = "g";
            KeyPress(letter);
        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            letter = "h";
            KeyPress(letter);
        }
        if (Input.GetKeyDown(KeyCode.I))
        {
            letter = "i";
            KeyPress(letter);
        }
        if (Input.GetKeyDown(KeyCode.J))
        {
            letter = "j";
            KeyPress(letter);
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            letter = "k";
            KeyPress(letter);
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            letter = "l";
            KeyPress(letter);
        }
        if (Input.GetKeyDown(KeyCode.M))
        {
            letter = "m";
            KeyPress(letter);
        }
        if (Input.GetKeyDown(KeyCode.N))
        {
            letter = "n";
            KeyPress(letter);
        }
        if (Input.GetKeyDown(KeyCode.O))
        {
            letter = "o";
            KeyPress(letter);
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            letter = "p";
            KeyPress(letter);
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            letter = "q";
            KeyPress(letter);
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            letter = "r";
            KeyPress(letter);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            letter = "s";
            KeyPress(letter);
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            letter = "t";
            KeyPress(letter);
        }
        if (Input.GetKeyDown(KeyCode.U))
        {
            letter = "u";
            KeyPress(letter);
        }
        if (Input.GetKeyDown(KeyCode.V))
        {
            letter = "v";
            KeyPress(letter);
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            letter = "w";
            KeyPress(letter);
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            letter = "x";
            KeyPress(letter);
        }
        if (Input.GetKeyDown(KeyCode.Y))
        {
            letter = "y";
            KeyPress(letter);
        }
        if (Input.GetKeyDown(KeyCode.Z))
        {
            letter = "z";
            KeyPress(letter);
        }
	 
        

    }
}
