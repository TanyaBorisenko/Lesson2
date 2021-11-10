namespace FourthHomeWork
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ISorting bubbleSort = new BubbleSort();
            ISorting shellSort = new ShellSort();

            bubbleSort.Sort();
            shellSort.Sort();
        }
    }
}