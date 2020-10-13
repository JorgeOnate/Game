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

        hangman = new Hangman(cont);

        word = GameObject.FindWithTag("Word").GetComponent<TextMeshProUGUI>();

        word.text = hangman.getWord();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
