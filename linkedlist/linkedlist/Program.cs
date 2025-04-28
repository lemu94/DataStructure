namespace linkedlist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkeList<int> test = new LinkeList<int>();
            test.Add(10);
            test.Add(452);
            test.Add(20);
            test.Add(35);
            test.AddBeginning(55);
            test.ShowList();
            test.DeleteAtIndex(2);
            test.ShowList();
            test.addIndex(2, 54);
            test.ShowList();
            Console.WriteLine(test.getCount());
            


            Console.WriteLine("Hello, World!");
            Console.ReadLine();
        }
    }
}
