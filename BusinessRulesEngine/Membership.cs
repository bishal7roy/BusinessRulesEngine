using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRulesEngine
{
    public class Membership
    {
        private string _membershipType = "";
        private string _emailID = "";

        public Membership(string productType, string emailID)
        {
            _emailID = emailID;
            _membershipType = productType;
            Console.WriteLine("We are processing your Request");
        }
    }
}
