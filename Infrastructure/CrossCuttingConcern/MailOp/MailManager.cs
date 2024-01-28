using Infrastructure.Const;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.CrossCuttingConcern.MailOp
{
    public class MailManager
    {
        public static bool Seed(string to, string title, string message)
        {
            MailMessage msg = new MailMessage(CoreKeys.EMAILADDRESS, to);
            msg.Subject = title;
            msg.Body = message;
            msg.IsBodyHtml = true; //body de html kullanılacak mı kullanılmayacak mı diye true veya false değer döner. Kullanılacaksa true değeri döndür.

            //msg.Attachments //maile kod ile dosya da ekleyebiliyoruz. //msg.Attachments(new Attachment("C:\file.zip"));

            SmtpClient smtp = new SmtpClient();
            smtp.Credentials = new NetworkCredential(CoreKeys.EMAILUSER, CoreKeys.EMAILPASSWORD);
            smtp.Host = "smtp-mail.outlook.com"; //senin özel mailin (domaini olan) veya google ve hotmail servislerinin özel host bağlantı linki olur onu koyman lazım .  örnek olarak google smtpsi => ‘smtp.gmail.com’ bu şekilde koyulmalı.
            //domainin varsa zaten smtp bölümünde size smtpyi göstermektedir.
            smtp.Port = 587;   //25, 465, 587 portları kullanımda fakat 25 portu ülkemizde kullanılmamaktadır.

            smtp.EnableSsl = true; //Bu değer şirket mailleri (domainli mailler) için false olarak yazılmalı.
            smtp.Send(msg);
            return true;
        }
    }
}
