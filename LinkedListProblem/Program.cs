namespace LinkedListProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Linked List Operation:");
            LinkedList list = new LinkedList();

            Console.WriteLine("Select \n1.Create LinkedList \n 2.Add \n 3.Insert At Particular Position \n 4.DeleteFirstNode \n 5.DeleteLastNode" );
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                  list.Add(56);
                  list.Add(30);
                  list.Add(70);
                  list.Display();
                  break;
               case 2:
                  list.AddReverseOrder(70);
                  list.AddReverseOrder(30);
                  list.AddReverseOrder(56);
                  list.Display();
                  break;
               case 3:
                    list.Add(56);
                    list.Add(70);
                    list.InsertAtParticularPosition(1, 30);
                    list.Display();
                    break;

                case 4:
                    list.Add(56);
                    list.Add(30);
                    list.Add(70);
                    list.RemoveFirstElement();
                    list.Display();
                    break;
                case 5:
                    list.Add(56);
                    list.Add(30);
                    list.Add(70);
                    list.RemoveLastElement();
                    list.Display();
                    break;

                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }
        }
    }
}