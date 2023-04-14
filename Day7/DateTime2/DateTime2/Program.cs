using System;

namespace DateTime2
{
    public class Program
    {
        static void Main(string[] args)
        {

            //gives year, month, date , hour, minute, second
            var dt1 = new DateTime(2023, 4, 11,3,15,32);
            Console.WriteLine(dt1);     
            //11-04-2023 03:15:32

            //gives month/day/year(last 2 numbers) format
            Console.WriteLine(dt1.ToString("MM/dd/yyyy"));  
            //04-11-2023

            //gives month/day/year(full) format
            Console.WriteLine(dt1.ToString("MM/dd/yyyy"));  
            //04-11-2023

            //gives day/month/year(last 2) format
            Console.WriteLine(dt1.ToString("dd/MM/yy"));   
            //11-04-23

            //gives first 3 letters of day and month in no & 3 letters and year
            Console.WriteLine(dt1.ToString("ddd, dd MMM yyyy"));    
            //Tue, 11 Apr 2023

            //gives day in letters and month in no and full in letters and year in last 2 no
            Console.WriteLine(dt1.ToString("dddd, dd MMMM yy"));    
            //Tuesday, 11 April 23
        }
    }
}
