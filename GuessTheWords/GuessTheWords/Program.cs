using System;
using System.Collections.Generic;
using System.Text;

namespace GuessTheWords
{
    class Program
    {

        static void Main()
        {
            Console.Write("Enter new word : ");
            string newWord = Console.ReadLine();
            Console.Clear();

            IsExit();

            StringBuilder word = new StringBuilder();
            string secretWord = newWord;
            List<char> wrongInputLetters = new List<char>();
            int count = 6;

            if (newWord != null)
                for (int i = 0; i < newWord.Length; i++)
                {
                    word.Append("_");
                }

            Console.WriteLine("Word is :{0}", word);
            Console.WriteLine();
            try
            {
                for (var i = 0; i < 10; i++)
                {

                    if (count < 6)
                    {
                        Console.WriteLine();
                        Console.Write("Wront letters are :  ");
                        foreach (var wrongLetter in wrongInputLetters)
                        {
                            Console.Write(wrongLetter + " ");
                        }
                        Console.WriteLine();
                    }
                    if (count == 0) { IsExit(); }
                    Console.WriteLine();
                    Console.WriteLine("You have attempt : {0}", count);
                    Console.WriteLine();
                    Console.Write("Enter letter : ");
                    string letter = Console.ReadLine();
                    Console.WriteLine();
                    Console.Write(new string('*', 30));
                    if (secretWord != null)
                    {
                        var letterIndex = secretWord.IndexOf(letter ?? throw new InvalidOperationException(), StringComparison.Ordinal);
                        Console.WriteLine();

                        if (letterIndex < 0)
                        {
                            wrongInputLetters.Add(Convert.ToChar(letter));

                            Console.WriteLine();
                            Console.WriteLine("Word is : {0}", word);
                            count--;
                            continue;
                        }
                        do
                        {
                            word[letterIndex] = Convert.ToChar(letter);

                        } while ((letterIndex = secretWord.IndexOf(Convert.ToChar(letter), letterIndex + 1)) > 0);


                    }

                    Console.WriteLine("Word is : {0}", word);


                    if (word.ToString() == newWord)
                    {
                        Console.WriteLine("You are win!!!");
                        Console.ReadLine();
                        IsExit();
                    }

                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);

            }

            Console.ReadLine();
        }

        static void IsExit()
        {

            Console.Clear();
            Console.Write("\t\t\t Do you wont to play y/n : ");
            string result = Console.ReadLine();
            if (result != null)
            {
                result = result.ToUpper();
                if (result == "N")
                {
                    Environment.Exit(0);
                }
            }

            Console.Clear();

        }

    }
}
