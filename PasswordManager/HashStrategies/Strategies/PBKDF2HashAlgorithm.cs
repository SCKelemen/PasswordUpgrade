using System;

namespace PasswordManager.HashStrategies.Strategies 
{

    public class PBKDF2HashAlgorithm : HashAlgorithm, IHashAlgorithm 
    {
        public PBKDF2HashAlgorithm() : base("pbkdf2") 
        {
            
        }
    }
}