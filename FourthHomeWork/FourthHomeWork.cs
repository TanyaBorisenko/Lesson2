namespace FourthHomeWork
{
    public class FourthHomeWork
    {
        //1.
        // private static List<int> _numbers = new List<int>() {1, 2, 45, 67, 84, 128, 652, 903};
        // private static List<int> _anotherNumbers = new List<int>() {56, 876, 456, 45, 903, 479, 2, 128, 340};
        //
        // public static void Main(string[] args)
        // {
        //     // var result = _numbers.Union(_anotherNumbers);
        //     //
        //     // foreach (var number in result)
        //     // {
        //     //     Console.WriteLine(number);
        //     // }
        //     var result = _numbers.Concat(_anotherNumbers);
        //
        //     foreach (var number in result)
        //     {
        //         Console.WriteLine(number);
        //     }
        // }
        //2.
        // static void Main(string[] args)
        // {
        //     Queue<int> numbers = new Queue<int>();
        //     numbers.Enqueue(345);
        //     numbers.Enqueue(34);
        //     numbers.Enqueue(3);
        //     numbers.Enqueue(7893);
        //     numbers.Enqueue(78);
        //     numbers.Enqueue(230);
        //     numbers.Enqueue(2);
        //
        //     int max = numbers.Max();
        //     int min = numbers.Min();
        //
        //     var a = numbers
        //         .SkipWhile(n => n != max & n != min)
        //         .Reverse()
        //         .SkipWhile(n => n != max & n != min)
        //         .Sum();
        //
        //     Console.WriteLine(a);
        // }
        //3.
        // public static void Main(string[] args)
        // {
        //     var linkedList = new LinkedList<int>();
        //     linkedList.AddFirst(1);
        //     linkedList.AddFirst(2);
        //     linkedList.AddFirst(3);
        //     linkedList.AddFirst(4);
        //     linkedList.AddFirst(5);
        //     linkedList.AddFirst(6);
        //
        //     while (linkedList.Count != 1)
        //     {
        //         for (int i = 0; i < linkedList.Count; i++)
        //         {
        //             if (i % 2 != 0)
        //             {
        //                 linkedList.Remove(linkedList.ElementAt(i));
        //             }
        //         }
        //     }
        //     Console.WriteLine($"Last person is number {linkedList.ElementAt(0)}.");
        // }
        //4.
    }
}