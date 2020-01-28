using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace GoodCodeBadCode.CH03.SingleResponsibility
{
    public class EmailClient
    {
        private Credential _credential;

        public EmailClient(Credential credential)
        {
            _credential = credential;
        }

        public void SendMail(TextFileData textFileData, List<Recipient> recipients)
        {
            File.WriteAllText(textFileData.FileName, textFileData.Text);
            var smtp = new Smtp(_credential);
            //smtp.SendMessage();
        }
    }
}
