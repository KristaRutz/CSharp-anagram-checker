using System;
using System.Collections.Generic;

namespace AnagramFinder.Models
{
  public class Anagram
  {
    public string Word { get; set; }
    public string[] PotentialAnagrams { get; set; }
    private static string[] _dictionary = new string[] { "tar", "rat", "arc", "car", "elbow", "below", "state", "taste", "cider" };
    private static string[] _alphaDictionary = new string[] { "tar", "rat", "arc", "car", "elbow", "below", "state", "taste", "cider" };

    public Anagram(string word, string[] potentialAnagrams)
    {
      Word = word;
      PotentialAnagrams = potentialAnagrams;
    }
    public static string SortAndTrim(string word)
    {
      char[] wordCharacters = word.ToLower().ToCharArray();
      Array.Sort(wordCharacters);
      string wordCharactersString = new string(wordCharacters).Trim();
      return wordCharactersString;
    }
    public static bool CheckAnagram(string word, string potentialAnagram)
    {
      if (word == potentialAnagram)
      {
        return true;
      }
      return false;
    }
    public static List<string> GetAllAnagrams(string word, string[] potentialAnagrams)
    {
      string sortedAndTrimmedWord = SortAndTrim(word);
      List<string> potentialAnagramsList = new List<string>();
      foreach (string item in potentialAnagrams)
      {
        string sortedAndTrimmedItem = SortAndTrim(item);
        if (sortedAndTrimmedWord.Length == sortedAndTrimmedItem.Length)
        {
          if (CheckAnagram(sortedAndTrimmedWord, sortedAndTrimmedItem))
          {
            potentialAnagramsList.Add(item.Trim());
          }
        }
      }
      return potentialAnagramsList;
    }
    public static void PrintList()
    {
      foreach (string item in _dictionary)
      {
        Console.WriteLine(item);
      }
    }
  }
}