using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQSamples
{
    public class Standard
    {
        private int _standardID;
        public int StandardID { get { return _standardID; } set { _standardID = value; } }
        private string _standardName;
        public string StandardName { get { return _standardName; } set { _standardName = value; } }

        public Standard(int standardID, string standardName)
        {
            StandardID=standardID;
            StandardName=standardName;
        }

        public Standard()
        {
        }
    }
}
