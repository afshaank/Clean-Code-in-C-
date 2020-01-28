using System;
using System.Collections.Generic;
using System.Text;

namespace GoodCodeBadCode.CH03.SingleResponsibility
{
    public struct Credential
    {
        public string EmailAddress { get; }
        public string Password { get; }

        public Credential(string email, string password)
        {
            EmailAddress = email;
            Password = password;
        }
    }
}
