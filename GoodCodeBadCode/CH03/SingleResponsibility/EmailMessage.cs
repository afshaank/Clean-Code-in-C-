using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoodCodeBadCode.CH03.SingleResponsibility
{
    public class EmailMessage
    {
        public string To { get; private set; }
        public string Cc { get; private set; }
        public string Bcc { get; private set; }
        public Message Message { get; private set; }

        public EmailMessage(Message message, List<Recipient> recipients)
        {
            SetRecipients(recipients);
            Message = message;
        }

        private void SetRecipients(List<Recipient> recipients)
        {
            To = string.Join("; ", from item in recipients where item.RecipientType == RecipientType.To select item.Email);
            Cc = string.Join("; ", from item in recipients where item.RecipientType == RecipientType.Cc select item.Email);
            Bcc = string.Join("; ", from item in recipients where item.RecipientType == RecipientType.Bcc select item.Email);
        }
    }
}
