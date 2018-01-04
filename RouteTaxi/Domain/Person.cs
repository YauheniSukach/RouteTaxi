using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Person
    {
        string login;
        public string Login
        {
            get { return login; }
            set { login =value; }
        }
        string pass;
        public string Pass
        {
            get { return pass; }
            set { pass = value; }
        }
        string firstname;
        public string FirstName
        {
            get { return firstname; }
            set { firstname = value; }
        }
        string lastname;
        public string LastName
        {
            get { return lastname; }
            set { lastname = value; }
        }
        string from;
        public string From
        {
            get { return from; }
            set { from = value; }
        }
        string to;
        public string To
        {
            get { return to; }
            set { to = value; }
        }
        DateTime when;
        public DateTime When
        {
            get { return when; }
            set { when = value; }
        }
        DateTime time;
        public DateTime Time
        {
            get { return time; }
            set { time = value; }
        }
        public override string ToString()
        {
            return From + "-" + To + "," + When +","+Time;
        }
    }
}
