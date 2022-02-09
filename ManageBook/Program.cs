using System;
using MyBookLibrary;

namespace ManageBook
{
    public class Program:Menu
    {
        private ListBook list = new ListBook();
        private Validate validate = new Validate();
        public Program()
        {
            this.setTitle("List Book");
            this.getValueList().Add("Add new book");
            this.getValueList().Add("Update a book");
            this.getValueList().Add("Delete a book");
            this.getValueList().Add("List all book");
            this.getValueList().Add("Quit");
        }
        public override void execute(int n)
        {
            switch (n)
            {
                case 1:
                    Console.Write("Enter ID: ");
                    int id1 = validate.checkInteger();
                    Console.Write("Enter Name: ");
                    String name1 = validate.checkInputString();
                    Console.Write("Enter Publisher: ");
                    String publisher1 = validate.checkInputString();
                    Console.Write("Enter price: ");
                    double price1 = validate.checkDouble();
                    list.AddBook(id1, name1, publisher1, price1);
                    break;
                case 2:
                    Console.Write("Enter ID: ");
                    int id2 = validate.checkInteger();
                    if(list.existID(id2) != null)
                    {
                        Console.Write("Enter Name: ");
                        String name2 = validate.checkInputString();
                        Console.Write("Enter Publisher: ");
                        String publisher2 = validate.checkInputString();
                        Console.Write("Enter price: ");
                        double price2 = validate.checkDouble();
                        list.Update(id2, name2, publisher2, price2);
                    }
                    else Console.WriteLine("Status of the action: failure\nId do not exist");
                    break;
                case 3:
                    Console.Write("Enter ID: ");
                    int id = validate.checkInteger();
                    Console.WriteLine("You really wants to delete that book.(Y/N)");
                    if (validate.checkInputYN()) list.Delete(id);
                    break;
                case 4:
                    list.PrintAll();
                    break;
            }
        }

        static void Main(string[] args)
        {
            Program program = new Program();
            program.run();
        }
    }
}
