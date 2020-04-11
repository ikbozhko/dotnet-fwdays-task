using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace dotNetFWDays
{
    public class Program
    {
        public static void Main()
        {
            var inputText = File.ReadAllText("mess.txt");

            var occurrenceByChars = new Dictionary<char, int>();

            foreach (var character in inputText)
            {
                occurrenceByChars[character] = occurrenceByChars.ContainsKey(character) ? occurrenceByChars[character] + 1 : 1;
            }

            var resultBuilder = new StringBuilder();

            foreach (var character in inputText)
            {
                if (occurrenceByChars[character] < 10)
                {
                    resultBuilder.Append(character);
                }
            }

            var result = resultBuilder.ToString();

            Console.WriteLine(result);
        }
    }
}
