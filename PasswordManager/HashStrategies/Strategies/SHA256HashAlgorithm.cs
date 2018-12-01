using System;

namespace PasswordManager.HashStrategies.Strategies 
{

    public class SHA256HashAlgorithm : HashAlgorithm, IHashAlgorithm 
    {
        public SHA256HashAlgorithm() : base("sha256") 
        {
            
        }
    }
}