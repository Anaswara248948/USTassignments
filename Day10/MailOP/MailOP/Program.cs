using System;
using System.Collections.Generic;

namespace MailOP
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Mail> ls = new List<Mail>();

            Console.WriteLine("Enter the name of the folder : ");
            string name=Console.ReadLine();
            MailFolder mf = new MailFolder (name, ls);
            Mail m=new Mail ();

            while (true)
            {
                Console.WriteLine("1. Add Mail");
                Console.WriteLine("2. Delete Mail");
                Console.WriteLine("3. Display Mails");
                Console.WriteLine("4. Exit");

                Console.WriteLine("Enter the choice : ");
                int ch=int.Parse(Console.ReadLine());                
                
                switch(ch)
                {
                    case 1:
                        //MailFolder m1 = new MailFolder(folderName,ls);
                        Console.WriteLine("Enter the details of mail in CSV format:");
                        string s1 = Console.ReadLine();
                        m=Mail.CreateMail(s1);
                        mf.AddMailToFolder(m);

                                                                        
                        break;

                    case 2:
                        Console.WriteLine("Enter the id to be removed : ");
                        long b=long.Parse(Console.ReadLine());

                        mf.RemoveMailFromFolder(b);

                        break;

                    case 3:
                        Console.WriteLine($"Mail in {name}");
                         mf.DisplayMails();
                        //Console.WriteLine("Mail Successfully added");
                        break;

                    case 4:
                        break;

                    default:
                        Console.WriteLine("Enter valid choice");
                        break;
                }

            }
            
        }
    }
}
