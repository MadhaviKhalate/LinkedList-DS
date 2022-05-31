using System;

namespace LinkedList
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("1.Create LinkedList \n2.Add new node in LinkedList \n3.Append value in LinkedList" +
                "\n4.Insert Value in LinkedList");
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
                   
                        break;
                    
                case 4:
                        break;
                    
                default:
                        break;
                    
            }
        }
    }
}