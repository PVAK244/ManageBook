using System;

namespace ManageBook
{
    public class Validate
    {
        public int checkInteger()
        {
            while (true)
            {
                try
                {
                    int result = int.Parse(Console.ReadLine());
                    if (result < 0) throw new Exception();
                    return result;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid.");
                    Console.Write("Enter again: ");
                }
                catch (Exception)
                {
                    Console.WriteLine("Number must be more than or equal 0");
                    Console.Write("Enter again: ");
                }
            }
        }
        public double checkDouble()
        {
            while (true)
            {
                try
                {
                    double result = double.Parse(Console.ReadLine());
                    if (result <= 0) throw new Exception();
                    return result;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid.");
                    Console.Write("Enter again: ");
                }
                catch (Exception)
                {
                    Console.WriteLine("Price must be more than 0");
                    Console.Write("Enter again: ");
                }
            }
        }

        public String checkInputString()
        {
            while (true)
            {
                String result = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(result))
                {
                    Console.WriteLine("Not Empty.");
                    Console.Write("Enter again: ");
                }
                else return result;
            }
        }

        public Boolean checkInputYN()
        {
            while (true)
            {
                String result = this.checkInputString();
                if (result.Equals("Y", StringComparison.OrdinalIgnoreCase)) return true;
                if (result.Equals("N", StringComparison.OrdinalIgnoreCase)) return false;

                Console.WriteLine("Please input y/Y or n/N");
                Console.Write("Enter Again: ");
            }
        }
    }
}
