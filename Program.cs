using System;

namespace Base64Encoding
{
    class Program
    {
        static void Main(string[] args)
        {
            string plainText = "Faffiage !";
            string base64String = "RmFmZmlhZ2UgIQ==";
            Console.WriteLine(Base64Encode(plainText)); // Outputs : "RmFmZmlhZ2UgIQ=="
            Console.WriteLine(Base64Decode(base64String)); // Outputs : "Faffiage !"


        }

        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }

        public static string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }
    }
}
