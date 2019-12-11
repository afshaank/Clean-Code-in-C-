using FakeCompany.Core.Security;
using System;
using System.Diagnostics;

namespace GoodCodeBadCode.CH03
{
    public class MultipleResponsibilities
    {
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
