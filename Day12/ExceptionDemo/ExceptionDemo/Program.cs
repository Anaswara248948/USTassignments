using System;
using System.Threading.Tasks;

namespace ExceptionDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            int k = 10;
            Console.WriteLine("Eneter a no : ");
            int i = int.Parse(Console.ReadLine());

            int[] a=new int[5];
            

            try
            {               
                k = k / i;
                a[10] = 9;   //always gives error
                Console.WriteLine("Helloooo");
            }
            catch (DivideByZeroException  e) 
            {
                Console.WriteLine(e.Message);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("finally!!!!!!");
            }

            Console.WriteLine("Remaining program....");
        }
    }
}
