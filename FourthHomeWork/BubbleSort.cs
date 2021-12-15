using System;

namespace FourthHomeWork
{
    public class BubbleSort : ISorting
    {
        void ISorting.Sort()

        {
            string[] words = {"words", "mother", "class", "cat"};
            string temp;

            for (int i = 0; i < words.Length; i++)
            {
                for (int j = words.Length - 1; j > i; j--)
                {
                    if (words[j - 1].Length < words[j].Length)
                    {
                        temp = words[j - 1];
                        words[j - 1] = words[j];
                        words[j] = temp;
                    }
                }
            }

            foreach (var s in words)
            {
                Console.WriteLine(s);
            }
        }
    }
}