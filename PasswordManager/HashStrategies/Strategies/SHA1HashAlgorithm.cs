using System;

namespace PasswordManager.HashStrategies.Strategies 
{

    public class SHA1HashAlgorithm : HashAlgorithm, IHashAlgorithm 
    {
        public SHA1HashAlgorithm() : base("sha1") 
        {
            
        }
    }
}