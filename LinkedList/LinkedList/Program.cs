using System;

namespace LinkedList
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("1.Create LinkedList \n2.Add new node in LinkedList \n3.Append value in LinkedList"+
                "\n4.Insert Value in LinkedList \n5.Delete First Node \n6.Delete Last Node");
            Console.WriteLine("Enter a your option:");
            int option = Convert.ToInt32(Console.ReadLine());
            LinkedListDS linkList = new LinkedListDS();
            switch (option)
            {
                case 1:
                        linkList.Create(56);
                        linkList.Create(30);
                        linkList.Create(70);
                        //list.Display();
                        break;
                case 2:
                        linkList.AddNode(70);
                        linkList.AddNode(30);
                        linkList.AddNode(56);
                        linkList.DisplayList();
                    break;
                    
                case 3:
                        linkList.AppendNode(56);
                        linkList.AppendNode(30);
                        linkList.AppendNode(70);
                        linkList.DisplayList();
                    break;
                    
                case 4:
                    linkList.AddNode(56);
                    linkList.AddNode(70);
                    Console.WriteLine("Before inserting New Node:");
                    linkList.DisplayList();
                    linkList.InsertNode(2, 30);
                    Console.WriteLine("\nAfter inserting New Node:");
                    linkList.DisplayList();
                    break;

                case 5:
                    linkList.AddNode(56);
                    linkList.AddNode(30);
                    linkList.AddNode(70);
                    Console.WriteLine("Before Deleting First element:");
                    linkList.DisplayList();
                    linkList.DeleteFirstNode();
                    Console.WriteLine("\nAfter Deleting First element:");
                    linkList.DisplayList();
                    break;

                case 6:
                    break;

                default:
                        Console.WriteLine("Enter valid option");
                        break;
                    
            }
        }
    }
}