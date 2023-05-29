using System;
namespace DotNetTutorials
{
    public class PowerOf2
    {
        static void Main(string[] args)
        {
            try
            {
                int no;
                int remainder;
                Console.WriteLine("Enter a no to check");
                no = Convert.ToInt32(Console.ReadLine());

                if (no == 1)
                    Console.Write("It is power of 2.");
                else
                {
                    while (no > 1)
                    {
                        remainder = no % 2;
                        if (remainder != 0)
                            break;
                        no /= 2;
                    }
                    if (no == 1)
                        Console.WriteLine("It is a power of 2");
                    else
                        Console.WriteLine("It is not a power of 2");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

           
        }
    }
}