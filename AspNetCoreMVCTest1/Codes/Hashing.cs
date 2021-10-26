using System.Security.Cryptography;
using System.Text;

namespace AspNetCoreMVCTest1.Codes;

    public class Hashing : IHashing
    {
        //private string? _txt;
        //dependensy injection
        //public string Text { get; set; } //constructor
        //public Hashing(string text) => (Text) = (text); //property

        //public void SetText(string txt)
        //{
        //    _txt = txt;
        //}
        //public string? getText(string txt)
        //{
        //    return _txt;
        //}

        ////public string Tekstfelt() => "Txtfelt"; er det samme som:
        public string MD5Hash(string valeuToHash)
        {
            byte[] valueAsBytes = ASCIIEncoding.ASCII.GetBytes(valeuToHash);
            byte[] hasedMD5 = MD5.HashData(valueAsBytes);
            string hashedvalueasstring = Convert.ToBase64String(hasedMD5);
            return hashedvalueasstring;
        }

    public string Tekstfelt(string valeuToHash)
    {
        return "somehting";
    }

    public string BcryptHash(string valeuToHash)
    {
        string hashed = BCrypt.Net.BCrypt.HashPassword(valeuToHash,10, BCrypt.Net.SaltRevision.Revision2Y);
        return hashed;
    }
}

