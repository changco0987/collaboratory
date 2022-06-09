using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;


namespace Collaboratory
{
    public class Gmail
    {

        //This method is used to send email prompt and notification to a user
        public void sendMail(string Reciever, string MessageSubject, string Message)
        {

            using (SmtpClient client = new SmtpClient("smtp.gmail.com", 587))
            {
                client.EnableSsl = true;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential("collaboratory.app@gmail.com", "ohsmgvmyzgefyctb");//The email address and password of the sender

                MailMessage msgObj = new MailMessage();
                msgObj.To.Add(Reciever);//The person that recieve this email
                msgObj.From = new MailAddress("collaboratory.app@gmail.com");
                msgObj.Subject = MessageSubject;//The subject or what the email message is all about
                msgObj.Body = Message;//The message of the email
                client.Send(msgObj);//The sender
            }

        }

        public string[] resetCodeMsg(int uak) 
        {
            string[] msg = new string[2];

            //The message subject
            msg[0] = "Request to Reset Password";
            //The message body
            msg[1] = "Hi, this is your unique authentication key to reset your security password. \nTo reset your password please use the 8-digit code below:\n"+uak;

            return msg;
        }

        public string[] accountCreatedMsg(string userid) 
        {
            string[] msg = new string[2];

            //The message subject
            msg[0] = "Your Collaboratory Account has been created";
            //The message body
            msg[1] = "Welcome to Collaboratory App\n"+ userid +"\nYour Collaboratory ID will be used by other users to find you through collaboratory user finder\n" +
                "this will also be used to add you as a participant to repositories";

            return msg;
        }

        public string[] passwordUpdateNotif(string userid) 
        {
            string[] msg = new string[2];

            //The message subject
            msg[0] = "Your password has been updated!";
            //The message body
            msg[1] = "Hi, "+userid+"\nYou have successfully reset your collaboratory account password. \nThank you for using Collaboratory";

            return msg;
        }

        public string[] accountDeleteNotif(string userid) 
        {
            string[] msg = new string[2];

            //The message subject
            msg[0] = "Your account has been deleted!";
            //The message body
            msg[1] = "Hi, " + userid + "\nYou have successfully deleted your account in our server. \nThank you for using Collaboratory hoping to see you soon";

            return msg;
        }

        public string[] accountUpdateMsg(string userid) 
        {
            string[] msg = new string[2];

            //The message subject
            msg[0] = "Your account information has been updated!";
            //The message body
            msg[1] = "Hi, " + userid + "\nYou have successfully updated your account information in our server. \nThank you for using Collaboratory";

            return msg;
        }

    }
}
