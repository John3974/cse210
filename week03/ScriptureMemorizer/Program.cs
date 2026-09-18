using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

// ---------------------------------------------------------
// Scripture Memorizer Program
// ---------------------------------------------------------

// ---------------------------------------------------------
// Reference Class
// ---------------------------------------------------------

// This class represents a scripture reference.
public class Reference
{
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;

    // Constructor for a single verse
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = verse;
        _endVerse = verse;
    }

    // Constructor for a verse range
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }

    public string GetDisplayText()
    {
        if (_startVerse == _endVerse)
        {
            return $"{_book} {_chapter}:{_startVerse}";
        }

        return $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
    }
}


// ---------------------------------------------------------
// Word Class
// ---------------------------------------------------------

// This class represents an individual word in the scripture.
public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        if (!_isHidden)
        {
            return _text;
        }

        // Replace letters and numbers with underscores.
        // Punctuation remains visible.
        return Regex.Replace(_text, @"[\p{L}\p{N}]", "_");
    }
}


// ---------------------------------------------------------
// Scripture Class
// ---------------------------------------------------------

// This class stores the scripture reference and its words.
public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        _random = new Random();

        string[] wordList = text.Split(
            ' ',
            StringSplitOptions.RemoveEmptyEntries
        );

        foreach (string word in wordList)
        {
            _words.Add(new Word(word));
        }
    }

    // Hides a specified number of words.
    // Only words that have not already been hidden are selected.
    public void HideRandomWords(int numberToHide)
    {
        List<Word> visibleWords = new List<Word>();

        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                visibleWords.Add(word);
            }
        }

        int amountToHide = Math.Min(numberToHide, visibleWords.Count);

        for (int i = 0; i < amountToHide; i++)
        {
            int randomIndex = _random.Next(visibleWords.Count);

            visibleWords[randomIndex].Hide();

            visibleWords.RemoveAt(randomIndex);
        }
    }

    // Checks whether every word has been hidden.
    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }

        return true;
    }

    // Displays the reference and all the words.
    public string GetDisplayText()
    {
        string result = _reference.GetDisplayText() + "\n";

        foreach (Word word in _words)
        {
            result += word.GetDisplayText() + " ";
        }

        return result.Trim();
    }
}


// ---------------------------------------------------------
// Program Class
// ---------------------------------------------------------

public class Program
{
    public static void Main(string[] args)
    {
        /*
         * CREATIVITY / EXCEEDING REQUIREMENTS:
         *
         * In addition to the core requirements, this program
         * contains a small library of scriptures. The program
         * randomly selects one scripture when it starts.
         *
         * The program also uses the stretch challenge by
         * selecting only words that have not already been hidden.
         */

        List<Scripture> scriptureLibrary = new List<Scripture>();

        // Scripture 1
        scriptureLibrary.Add(
            new Scripture(
                new Reference("John", 3, 16),
                "For God so loved the world that he gave his only begotten Son that whoever believes in him should not perish but have eternal life."
            )
        );

        // Scripture 2 - Multiple verses
        scriptureLibrary.Add(
            new Scripture(
                new Reference("Proverbs", 3, 5, 6),
                "Trust in the Lord with all your heart and lean not on your own understanding in all your ways acknowledge him and he will make your paths straight."
            )
        );

        // Scripture 3
        scriptureLibrary.Add(
            new Scripture(
                new Reference("Philippians", 4, 13),
                "I can do all things through Christ who strengthens me."
            )
        );

        // Randomly select a scripture from the library.
        Random random = new Random();

        int selectedIndex = random.Next(scriptureLibrary.Count);

        Scripture scripture = scriptureLibrary[selectedIndex];


        // Main program loop
        while (true)
        {
            Console.Clear();

            // Display the scripture.
            Console.WriteLine(scripture.GetDisplayText());

            Console.WriteLine();
            Console.WriteLine(
                "Press Enter to hide some words or type 'quit' to exit."
            );

            string input = Console.ReadLine();

            // End the program if the user types quit.
            if (input != null &&
                input.Trim().ToLower() == "quit")
            {
                break;
            }

            // Hide three random words.
            scripture.HideRandomWords(3);

            // If all words are hidden, display the final
            // scripture and end the program.
            if (scripture.IsCompletelyHidden())
            {
                Console.Clear();

                Console.WriteLine(scripture.GetDisplayText());

                break;
            }
        }
    }
}