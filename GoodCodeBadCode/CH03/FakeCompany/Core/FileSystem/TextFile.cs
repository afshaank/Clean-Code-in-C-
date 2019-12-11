using System;

namespace FakeCompany.Core.FileSystem
{
    public class TextFile
    {
        public string ReadTextFromFile(string filename)
        {
            if (string.IsNullOrEmpty(filename))
            {
                throw new ArgumentException("message", nameof(filename));
            }

            throw new NotImplementedException();
        }

        public string SaveTextToFile(string text, string filename)
        {
            if (string.IsNullOrEmpty(text) || string.IsNullOrEmpty(filename))
            {
                throw new ArgumentException("message", nameof(text));
            }

            throw new NotImplementedException();
        }
    }
}
