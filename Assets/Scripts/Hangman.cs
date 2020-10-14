using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Hangman 
{
    public string word;
    public int lives = 3;
    public int attempts = 7;
    public int level;
    public string letters;
    public string guessWord;
    
    private string[] wordsLevel1 =
    {
        "airfare", "airplane", "airport", "automobile", "backpack", "baggage", "bags", "beach", "bicycle", "bike", "binoculars", "boat", "bus",
        "cab", "cabin", "camera", "campground", "camping", "car", "chart", "coast", "cruise", "currency", "customs", "depart", "departure",
        "destination", "downtime", "drive", "embark", "excursion", "expedition", "explore", "ferry", "flew", "flight", "fly", "foreign",
        "foreigner", "getaway", "go", "guide", "hiatus", "highway", "hike", "holiday", "hostel", "hotel", "inn", "island", "itinerary", "jet",
        "journey", "keepsake", "knapsack", "lake", "landing", "leave", "leisure", "lodge", "lodging", "luggage", "map", "motel", "mountains",
        "museum", "outdoors", "pack", "passage", "passport", "photographs", "photos", "pictures", "plane", "port", "postcard", "recreation",
        "relax", "relaxation", "reservations", "resort", "rest", "restaurant","return", "room", "sack", "safari", "sail", "scenary", "schedule",
        "sea", "seashore", "ship", "shore", "sights", "souvenir", "station", "stay", "subway", "suitcase", "sunscreen", "swim", "swimsuit",
        "takeoff", "taxi", "tent", "ticket", "tip", "tote", "tour", "tourist", "trail", "train", "tram", "tramway", "translate", "transportation",
        "travel", "trip", "trunk", "umbrella", "unpack", "vacation", "vehicle", "video", "visa", "visit", "voyage", "walk", "wander", "waterfall",
        "waterpark", "weekend", "yacht", "zoo"
    };
    private string[] wordsLevel2 = new string[2];
    private string[] wordsLevel3 = new string[2];


    public string Word
    {
        get => word;
        set => word = value;
    }

    public int Lives
    {
        get => lives;
        set => lives = value;
    }

    public int Attempts
    {
        get => attempts;
        set => attempts = value;
    }

    public string Letters
    {
        get => letters;
        set => letters = value;
    }

    public string GuessWord
    {
        get => guessWord;
        set => guessWord = value;
    }


    public Hangman(int level)
    {
        this.level = level;
        SelectRandomWord(this.level);
    }
    public void SelectRandomWord(int number)
    {
        string[] words = new string[2];
        if (number == 1)
        {
            words = wordsLevel1;
        }
        else if (number == 2)
        {
            words = wordsLevel2;
        }
        else
        {
            words = wordsLevel3;
        }
        
        this.word = words[Random.Range(0, words.Length)];
    }

    public string convertWord()
    {
        string oldWord = this.word;
        string newWord = "";
        for (int i = 0; i < oldWord.Length; i++)
        {
            newWord = newWord + "_";
        }

        this.guessWord = newWord;
        return newWord;
    }

    public void GuessWords(char letter)
    {
        string tempWord = "";
        
        for (int i = 0; i < word.Length; i++)
        {
            if (word[i].Equals(letter))
            {
                tempWord += letter;
            }
            else
            {
                tempWord += guessWord[i];
            }
        }

        this.guessWord = tempWord;
    }

}
