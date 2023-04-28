using System;
using System.Collections.Generic;
using System.Threading;

namespace MailOP
{
    public class MailFolder
    {
        private string _name;
        public string Name { get { return _name; } set { _name = value; } }

        private List<Mail> _mailList = new List<Mail>();
        public List<Mail> MailList { get {  return _mailList; } set { _mailList = value; } }

        public MailFolder() 
        { 
        }

        public MailFolder(string name, List<Mail> mailList)
        {
            Name = name;
            MailList = mailList;
        }

        public void AddMailToFolder(Mail mail)
        {
            MailList.Add(mail);
            Console.WriteLine("Mail Successfully added");
        }


        public bool RemoveMailFromFolder(long id)
        {
            int count = 0;
            foreach (var item in MailList)
            {
                if (item.Id == id)
                {
                    MailList.Remove(item);

                    count = 1;
                    break;
                }
            }
            if (count == 1)
            {
                Console.WriteLine("Mail Successfully deleted");
                return true;
            }
            else
            {
                Console.WriteLine("Mail not found in the folder");
                return false;
            }
        }

        public void DisplayMails()
        {
            
            
                if (MailList.Count == 0)
                {
                    Console.WriteLine("No mails to show");
                }
                else
                {
                    Console.WriteLine("Mail in {0}\n", MailList);
                    Console.WriteLine("{0} {1,15} {2,15} {3,15} {4,15} {5,15} {6,15}", "Id", "From", "To", "Subject", "Content", "Received Date", "Size");
                }
            

            
            foreach(var mail in MailList)
            {
                Console.WriteLine(mail);
            }
        }

    }
}
