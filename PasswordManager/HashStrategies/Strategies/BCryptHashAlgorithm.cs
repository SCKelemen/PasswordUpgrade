using System;

namespace PasswordManager.HashStrategies.Strategies 
{

    public class BCryptHashAlgorithm : HashAlgorithm, IHashAlgorithm 
    {
        public BCryptHashAlgorithm() : base("bcrypt") 
        {
            
        }
    }
}