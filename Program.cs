using System;
using System.Collections.Generic;

namespace list_dictionaries_words
{
    class Program
    {
        static void Main(string[] args)
        {
            // Make a new list
            List<Dictionary<string, string>> dictionaryOfWords = new List<Dictionary<string, string>>();
            
            /*
                You want to track the following about each word:
                    word, definition, part of speech, example sentence

                Example of one dictionary in the list:
                {
                    "word": "excited",
                    "definition": "having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness",
                    "part of speech": "adjective",
                    "example sentence": "I am excited to learn C#!"
                }
            */

            // Create dictionary to represent a few word
      

            // Add each of the 4 bits of data about the word to the Dictionary
            Dictionary<string, string> mario = new Dictionary<string, string>(){
                {"Word", "Mario"},
                {"Definition", "One of the best and biggest turning points in gaming"},
                {"part of speech", "Noun"},
                {"example", "I was playing some mario with the homies talk about Nostalgia"}
            };

            Dictionary<string, string> cellphone = new Dictionary<string, string>(){
                {"Word", "Cellphone"},
                {"Definition", "Technology that no first world person can live without"},
                {"part of speech", "Noun"},
                {"example", "I lost my cellphone at a party and my life stopped."}
            };
           

            // Add Dictionary to your `dictionaryOfWords` list

            dictionaryOfWords.Add(mario);


            // create another Dictionary and add that to the list
            dictionaryOfWords.Add(cellphone);


            /*
                Iterate your list of dictionaries and output the data

                Example output for one word in the list of dictionaries:
                    word: excited
                    definition: having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness
                    part of speech: adjective
                    example sentence: I am excited to learn C#!
            */

            // Iterate the List of Dictionaries
            foreach (Dictionary<string, string> word in dictionaryOfWords)
            {
                // Iterate the KeyValuePairs of the Dictionary
                foreach (KeyValuePair<string, string> kvp in word)
                {
                    Console.WriteLine($"{kvp.Key}: {kvp.Value}");
                }
            }
        }
    }
}
