namespace AspNetCoreMVCTest1.Codes
{
    public interface IHashing
    {
        public string MD5Hash(string valeuToHash);
        public string BcryptHash(string valeuToHash);
    }
}
