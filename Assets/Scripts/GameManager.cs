using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class GameManager : MonoBehaviour
{
    
    [SerializeField]private GameObject background;
    [SerializeField]private TextMeshProUGUI word;
    private TextMeshPro words;
    int cont =0;
    private Hangman hangman;
    void Start()
    {
        //background = gameObject.GetComponent<>();
        if (background.tag == "1")
        {
            cont = 1;
        }
        if (background.tag == "2")
        {
            cont = 2;
        }
        if (background.tag == "3")
        {
            cont = 3;
        }
        //hangman = gameObject.AddComponent<Hangman>();
        
        word = gameObject.GetComponent<TextMeshProUGUI>();

        //word = gameObject.GetComponent<TextMeshProUGUI>();
        word.text = hangman.getWord();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
