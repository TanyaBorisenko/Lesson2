using System;

namespace FourthHomeWork
{
    public class ShellSort : ISorting
    {
        public void Sort()
        {
            int[] number = {23, 65, 7, 789, -45, 34, 8, -12, -67, 43};
            int j;
            int step = number.Length / 2;
            while (step > 0)
            {
                for (int i = 0; i < (number.Length - step); i++)
                {
                    j = i;
                    while ((j >= 0) && (number[j] > number[j + step]))
                    {
                        int temp = number[j];
                        number[j] = number[j + step];
                        number[j + step] = temp;
                        j -= step;
                    }
                }

                step = step / 2;
            }

            Array.Reverse(number);
            foreach (var num in number)
            {
                Console.WriteLine(num);
            }
        }
    }
}