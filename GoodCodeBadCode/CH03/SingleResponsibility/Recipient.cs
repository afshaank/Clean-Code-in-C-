using System;
using System.Collections.Generic;
using System.Text;

namespace GoodCodeBadCode.CH03.SingleResponsibility
{
    public struct Recipient
    {
        public string Name { get; }
        public string Email { get; }
        public RecipientType RecipientType { get; }

        public Recipient(string name, string email, RecipientType recipientType)
        {
            Name = name;
            Email = email;
            RecipientType = recipientType;
        }
    }
}
