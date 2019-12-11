using System;

namespace FakeCompany.Core.Security
{
    [Flags]
    public enum SecurityAlgorithm
    {
        Aes,
        AesCng,
        MD5,
        SHA5
    }
}