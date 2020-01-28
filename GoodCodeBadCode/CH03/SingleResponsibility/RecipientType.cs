using System;
using System.Collections.Generic;
using System.Text;

namespace GoodCodeBadCode.CH03.SingleResponsibility
{
    [Flags]
    public enum RecipientType
    {
        From,
        To,
        Cc,
        Bcc
    }
}
