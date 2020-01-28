using FakeCompany.Core.Security;
using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;

namespace GoodCodeBadCode.CH03.SingleResponsibility
{
    public class MultipleResponsibilities
    {
        public void SrpBrokenMethod(string folder, string filename, string text, string emailFrom, string password, string emailTo, string subject, string msg, string mediaType)
        {
            var file = $"{folder}{filename}";
            File.WriteAllText(file, text);
            MailMessage message = new MailMessage();
            SmtpClient smtp = new SmtpClient();
            message.From = new MailAddress(emailFrom);
            message.To.Add(new MailAddress(emailTo));
            message.Subject = subject;
            message.IsBodyHtml = true;
            message.Body = msg;
            Attachment emailAttachment = new Attachment(file);
            emailAttachment.ContentDisposition.Inline = false;
            emailAttachment.ContentDisposition.DispositionType =
            DispositionTypeNames.Attachment;
            emailAttachment.ContentType.MediaType = mediaType;
            emailAttachment.ContentType.Name = Path.GetFileName(filename);
            message.Attachments.Add(emailAttachment);
            smtp.Port = 587;
            smtp.Host = "smtp.gmail.com";
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential(emailFrom, password);
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Send(message);
        }

        public string DecryptString(string text, SecurityAlgorithm algorithm)
        {
            if (string.IsNullOrEmpty(text))
            {
                throw new ArgumentException("message", nameof(text));
            }
            Debug.WriteLine($"Encryption Algorithm: {algorithm}");
            throw new NotImplementedException();
        }

        public string EncryptString(string text, SecurityAlgorithm algorithm)
        {
            if (string.IsNullOrEmpty(text))
            {
                throw new ArgumentException("message", nameof(text));
            }
            Debug.WriteLine($"Encryption Algorithm: {algorithm}");
            throw new NotImplementedException();
        }

        public string ReadTextFromFile(string filename)
        {
            if (string.IsNullOrEmpty(filename))
            {
                throw new ArgumentException("message", nameof(filename));
            }
            Debug.WriteLine($"File Name: {filename}");
            throw new NotImplementedException();
        }

        public string SaveTextToFile(string text, string filename)
        {
            if (string.IsNullOrEmpty(text) || string.IsNullOrEmpty(filename))
            {
                throw new ArgumentException("message", nameof(filename));
            }
            Debug.WriteLine($"File Name: {filename}");
            throw new NotImplementedException();
        }
    }
}
