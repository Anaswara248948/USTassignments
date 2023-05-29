using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Abstract1
{
    public abstract class Book
    {
        protected string title;
        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public abstract void setTitle(string s);
        public string getTitle()
        {
            return title;
        }
    }
    public class MyBook : Book
    {
        public override void setTitle(string s)
        {
            title = s;
        }
    }
}