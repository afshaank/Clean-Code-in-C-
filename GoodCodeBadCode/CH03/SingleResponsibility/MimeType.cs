using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace GoodCodeBadCode.CH03.SingleResponsibility
{
    [Flags]
    public enum MimeType
    {
        [Description("text/plain")]
        TextPlain
    }
}
