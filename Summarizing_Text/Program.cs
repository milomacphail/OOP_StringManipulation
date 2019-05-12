using System;
using System.Collections.Generic;

namespace Summarizing_Text
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string sentence = "A really really really really really really really really long sentence.";
            var summary = SummarizeText(sentence, 25);
            Console.WriteLine(summary);
        }

        static string SummarizeText(string text, int maxLength =20)
        {
            if (text.Length < maxLength)
                Console.WriteLine(text);

            var words = text.Split();
                    int totalChar = 0;
                    var summary = new List<string>();

                    foreach (string word in words)
                    {
                        summary.Add(word);

                        totalChar += word.Length + 1;
                        if (totalChar > maxLength)
                            break;
                    }

            return string.Join(" ", summary) + "...";

            }
        }
    }
}
