using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Count a total number of vowel or consonant

            string str;
            int vow = 0, con = 0;
                       
            Console.WriteLine("Enter a string : ");
            str=Console.ReadLine();

            //int len=0;
            //len = str.Length;

            for(int i=0;i< str.Length; i++)
            {
                if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u' || str[i] == 'A' || str[i] == 'E' || str[i] == 'I' || str[i] == 'O' || str[i] == 'U')
                {
                    vow++;
                }
                else if (str[i] >= 'a' && str[i] <= 'z'  || str[i] >= 'A' && str[i] <= 'Z')
                {
                    con++;
                }
            }

            Console.WriteLine("The no of Vowels in the string is : " + vow);
            Console.WriteLine("The no of Consonants in the string is : " + con);

        }
    }
}
