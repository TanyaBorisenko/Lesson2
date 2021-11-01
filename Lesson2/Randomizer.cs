using System;

namespace Lesson2
{
    public static class Randomizer
    {
        public static int GetRandomNumber(int maxValue) => new Random().Next(1, maxValue);
    }
}