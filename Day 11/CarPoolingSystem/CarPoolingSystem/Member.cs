using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CarPoolingSystem
{
    public class Member
    {
        
        private long _id;
        public long Id { get { return _id; } set { _id = value; } }


        private string _firstName;
        public string FirstName { get { return _firstName; } set { _firstName = value; } }


        private string _lastName;
        public string LastName { get { return _lastName; } set { _lastName = value; } }


        private string _email;
        public string Email { get { return _email; } set { _email = value; } }


        private string _contactNumber;
        public string ContactNumber { get { return _contactNumber; } set { _contactNumber = value; } }


        private string _liscenceNumber;
        public string LiscenceNumber { get { return _liscenceNumber; } set { _liscenceNumber = value; } }


        private DateTime _liscenceStartDate;
        public DateTime LiscenceStartDate { get {  return _liscenceStartDate; } set { _liscenceStartDate = value; } }


        private DateTime _liscenceExpiryDate;
        public DateTime LiscenceExpiryDate { get {  return _liscenceExpiryDate; } set { _liscenceExpiryDate = value;  } }


        public Member() 
        {
        }

        public Member(long _id, string _firstName, string _lastName, string _email, string _contactNumber,string _liscenceNumber, DateTime _liscenceStartDate, DateTime _liscenceExpiryDate)
        {
            Id = _id;           
            FirstName = _firstName;
            LastName = _lastName;
            Email = _email;
            ContactNumber = _contactNumber;
            LiscenceNumber= _liscenceNumber;
            LiscenceStartDate = _liscenceStartDate;
            LiscenceExpiryDate = _liscenceExpiryDate;
        }

        public override string ToString()
        {
            return string.Format($"Member : {_firstName},{_lastName}\n Member Contact details : {_contactNumber},{_email}");

        }


        public override bool Equals(object obj)
        {
            Member m1 = obj as Member;
            if (m1.FirstName == FirstName && m1.LastName == LastName && m1.ContactNumber == ContactNumber)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

       

    }

    
}
