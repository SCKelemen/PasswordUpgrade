using System;

namespace PasswordManager.HashStrategies.Strategies 
{

    public class MD5HashAlgorithm : HashAlgorithm, IHashAlgorithm 
    {
        public MD5HashAlgorithm() : base("md5") 
        {
            
        }
    }
}