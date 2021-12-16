using System;

namespace ASD_application
{
    public class EncryptionModule
    {

        public EncryptionModule()
        {
        }

        public string GenerateKeypair(string key)
        {
            return "keypair";
        }
        public string EncryptMessage(string message, string public_key)
        {
            return "ciphertext";
        }
    }
}