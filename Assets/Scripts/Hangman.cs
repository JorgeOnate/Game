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
    private string[] wordsLevel2 =
    {
        "bells","birth","blizzard","blustery","boots","bough","bow","box","angel","candle","candy","cap","card","carolers","caroling","carols","celebrate","celebration","ceremony",
        "charity","chestnuts","chill","chilly","chimney","christmas","christmastide","cider","coal","cold","cookie","creche","decorate","decorations","display","eggnog","elf","elves",
        "eve","evergreen","exchange","family","feast","festival","festive","fir","fireplace","firewood","frankincense","frosty","fruitcake","garland","gift","gingerbread","give","gold",
        "goodwill","goose","green","greetings","guest","happy","holiday","holly","hope","hug","icicle","icy","ivy","jesus","jolly","joy","joyful","kings","krampus","lights","list","log",
        "love","nativity","naughty","nice","nippy","noel","nutcracker","occasion","ornaments","package","pageant","parade","partridge","party","pie","pinecone","poinsettia","presents",
        "receive","red","reindeer","rejoice","reunion","ribbon","ritual","Rudolph","tidings","tinsel","toboggan","togetherness","toy","tradition","tree","trimming","trips","turkey","wassail",
        "winter","wintertime","wintry","wish","wonder","workshop","wrap","wreath"
        
    };
    private string[] wordsLevel3 =
    {
        "afraid","afterlife","alarming","angel","astronaut","autumn","alien","afterlife","ballerina","bat","beast","bizarre","black","blood","bone","boo","broomstick",
        "cackle","cadaver","candy","carve","cat","casket","chilling","cemetery","clown","cobweb","cloak","corpse", "coffin","costume","creepy","crown","dark","dead",
        "darkness","death","devil","disguise","demon","eerie","elf","enchant","eyeball","eyepatch","fairy","fangs","fantasy","fog","frighten","fright","fear","flashlight",
        "ghost","goblin","genie","grim","grave","gravestone","gruesome","hat","haunted","haunt","horrible","howl","horrify","imp","jumpsuit","king","lantern","magic","mask",
        "mist","moon","mummy","morbid","mysterious","monster","midnight","ninja","night","nightmare","orange","october","ogre","owl","party","phantasm","pirate","princess",
        "prank","queen","repulsive","rip","robot","robe","scare","scary","scarecrow","scream","shadow","shock","skeleton","skull","spell","spider","spirit","spook","strange",
        "supernatural","sweets","superhero","tarantula","terrible","terrify","thrilling","trick","troll","tomb","unnerving","vampire","vanish","wand","web","werewolf","wig",
        "witchcraft","warlock","weird","wicked","witch","wraith","wizardry","zombie"
    };


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
