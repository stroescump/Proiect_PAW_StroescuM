using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using Proiect_PAW_StroescuM.Exceptions;

namespace Proiect_PAW_StroescuM.Singletons
{
    public class Hash_SHA256
    {
        private static Hash_SHA256 instance = null;

        private Hash_SHA256()
        {
        }

        public static Hash_SHA256 getInstance()
        {
            if (instance != null)
            {
                throw new ExceptieCreareInstanteMultipleSingleton("Exista deja o instanta creata pentru clasa Hash_SHA256!");
            }
            else
            {
                instance = new Hash_SHA256();
            }
            return instance;
        }

        public string calculHash(string emailAddress)
        {
            byte[] plainData = ASCIIEncoding.UTF8.GetBytes(emailAddress);
            byte[] hashValue = null;
            SHA256Managed sha = new SHA256Managed();
            hashValue = sha.ComputeHash(plainData);
            sha.Dispose();
            return Convert.ToBase64String(hashValue);
        }
    }
}
