using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace BusinessLogicTier
{
    //Mã hóa mật khẩu theo kiểu MD5
    public class Encrypt
    {
        public string MD5(string password)
        {
            //mã hóa chuoi trong mot mang ki tu xac dinh thanh kieu byte
            byte[] textBytes = Encoding.Default.GetBytes(password);
            try
            {
                MD5CryptoServiceProvider cryptHandler;
                cryptHandler = new MD5CryptoServiceProvider();
                //tra ve mot bang bam(tra ve 16 ki tu random (0->255))
                byte[] hash = cryptHandler.ComputeHash(textBytes);
                string ret = "";
                // Loop through each byte of the hashed data  
                // and format each one as a hexadecimal string. 
                foreach (byte a in hash)
                {
                    ret += a.ToString("X2");
                }
                return ret;
            }
            catch
            {
                throw;
            }
        }
        public string MD52(string a, int solan)
        {
            string kq = a;
            for (int i = 0; i < solan; i++)
            {
                kq = MD5(kq);
            }
            return kq;
        }
    }
}
