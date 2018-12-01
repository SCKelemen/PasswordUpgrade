using System;

namespace PasswordManager.HashStrategies.Strategies 
{

    public class SCryptHashAlgorithm : HashAlgorithm, IHashAlgorithm 
    {
        public SCryptHashAlgorithm() : base("scrypt") 
        {
            
        }
    }
}