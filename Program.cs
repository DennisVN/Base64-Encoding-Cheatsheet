using System;
using System.Text;

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

            // One liner : 
            string encodedStr = Convert.ToBase64String(Encoding.UTF8.GetBytes("Faffiage !"));
            Console.WriteLine(encodedStr);

            string inputStr = Encoding.UTF8.GetString(Convert.FromBase64String(encodedStr));
            Console.WriteLine(inputStr);
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
