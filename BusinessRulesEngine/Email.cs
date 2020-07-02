using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRulesEngine
{
    public class Email
    {
        public Email()
        {
            Console.WriteLine("Email Team Notified.");
        }

        //To Send Email for Membership related payments
        public bool SendEmail(string toEmail, string subject, string mailBody)
        {
            try
            {
                string senderEmailID = ConfigurationManager.AppSettings["EmailID"].ToString();
                string senderPassword = ConfigurationManager.AppSettings["Password"].ToString();

                SmtpClient sc = new SmtpClient("smtp.gmail.com", 587);
                sc.EnableSsl = true;
                sc.Timeout = 100000;
                sc.DeliveryMethod = SmtpDeliveryMethod.Network;
                sc.UseDefaultCredentials = false;
                sc.Credentials = new NetworkCredential(senderEmailID, senderPassword);

                MailMessage mm = new MailMessage(senderEmailID, toEmail, subject, mailBody);
                mm.IsBodyHtml = true;
                mm.BodyEncoding = UTF8Encoding.UTF8;
                sc.Send(mm);

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
