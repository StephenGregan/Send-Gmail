using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppGmail
{
    class Program
    {
        static void Main(string[] args)
        {
            string mainBodyHtml = "This is a test";
            var msg = new MailMessage("", "", "Hi there", mainBodyHtml);
            msg.To.Add("");
            msg.IsBodyHtml = true;
            var smptClient = new SmtpClient("smpt.gmail.com", 587);
            smptClient.Credentials = new NetworkCredential("","");
            smptClient.EnableSsl = true;
            smptClient.Send(msg);
            Console.WriteLine("Email sent");
        }
    }
}
