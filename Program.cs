using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the original text:");
string originalText = Console.ReadLine();

Console.WriteLine("Enter the words to be scrambled (separated by spaces):");
string wordsToScrambleInput = Console.ReadLine();
string[] wordsToScramble = wordsToScrambleInput.Split(' ');

Console.WriteLine("Enter the replacement words (separated by spaces):");
string replacementWordsInput = Console.ReadLine();
string[] replacementWords = replacementWordsInput.Split(' ');

if (wordsToScramble.Length != replacementWords.Length)
{
    Console.WriteLine("The number of words to scramble and replacement words must match.");
}
else
{
    for (int i = 0; i < wordsToScramble.Length; i++)
    {
        originalText = originalText.Replace(wordsToScramble[i], replacementWords[i]);
    }

    Console.WriteLine("Scrambled Text:");
    Console.WriteLine(originalText);
}
    }
}