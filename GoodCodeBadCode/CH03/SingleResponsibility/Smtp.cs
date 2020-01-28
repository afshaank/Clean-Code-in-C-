﻿using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace GoodCodeBadCode.CH03.SingleResponsibility
{
    public class Smtp
    {
        private readonly SmtpClient _smtp;

        public Smtp(Credential credential)
        {
            _smtp = new SmtpClient
            {
                Port = 587,
                Host = "smtp.gmail.com",
                EnableSsl = true,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(credential.EmailAddress, credential.Password),
                DeliveryMethod = SmtpDeliveryMethod.Network
            };
        }

        public void SendMessage(MailMessage mailMessage)
        {
            _smtp.Send(mailMessage);
        }
    }
}
