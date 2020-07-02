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
            MembershipDetails(_membershipType, _emailID);
        }

        //To Call Send Email Method and check the status of email triggered.
        public void MembershipDetails(string productType, string emailID)
        {
            Email email = new Email();
            bool emailStatus;
            emailStatus = email.SendEmail(emailID, productType, "Membership is activated/upgraded.");
            if (emailStatus)
            {
                Console.WriteLine("Confirmation Email Sent Successfully");
            }

            else
            {
                Console.WriteLine("Our team will manually sent you a Confirmation Mail");
            }
        }
    }
}
