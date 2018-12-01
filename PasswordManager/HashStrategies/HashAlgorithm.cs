using System;

namespace PasswordManager.HashStrategies 
{

    public abstract class HashAlgorithm : IHashAlgorithm
    {
        private string _identifier;
        public HashAlgorithm(string identifier) 
        {
            _identifier = identifier;
        }

        public string Identifier => _identifier;
    }
}