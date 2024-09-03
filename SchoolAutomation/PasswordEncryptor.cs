using System;
using System.Security.Cryptography;
using System.Text;

namespace SchoolAutomation
{
    public static class PasswordEncryptor
    {

        public static string MD5Hash(string text)
        {
            MD5 md5 = new MD5CryptoServiceProvider();

            //compute hash from the bytes of text  
            //md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text));
            byte[] inputBytes = Encoding.ASCII.GetBytes(text);

            //get hash result after compute it  
            //byte[] result = md5.Hash;
            byte[] result = md5.ComputeHash(inputBytes);

            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                //change it into 2 hexadecimal digits  
                //for each byte  
                strBuilder.Append(result[i].ToString("x2"));
            }

            return strBuilder.ToString();


            
        }


    }
}
