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
            test.AddAtIndex(2, 54);
            test.ShowList();
            test.DeleteAtBeginning();
            test.ShowList();
            Console.WriteLine(test.SearchByPosition(0));
            Console.WriteLine(test.SearchByPosition(1));

            Console.WriteLine(test.getCount());
            Queue<int> Lqueue = new Queue<int>();
            Lqueue.Enqueue(102);
            Lqueue.Enqueue(50);
            Lqueue.Enqueue(40);
            Lqueue.Enqueue(60);
            Lqueue.Enqueue(20);
            Lqueue.Enqueue(870);

            Console.WriteLine(Lqueue.GetCount());
            Console.WriteLine(Lqueue.Peek());
            Lqueue.Show();
            Lqueue.Dequeue();
            Lqueue.Dequeue();
            Lqueue.Dequeue();
            Console.WriteLine(Lqueue.Peek());





            Console.WriteLine("Hello, World!");
            Console.ReadLine();
        }
    }
}
