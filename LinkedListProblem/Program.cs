namespace LinkedListProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Linked List Operation:");
            LinkedList list = new LinkedList();
            //list.Add(56);
            //list.Add(30);
            //list.Add(70);

            list.AddReverseOrder(70);
            list.AddReverseOrder(30);
            list.AddReverseOrder(56);


            list.Display();
        }
    }
}