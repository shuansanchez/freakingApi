using System;
using System.Globalization;
using System.IO;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace freakingApi
{
    public class ApiService
    {
        private const string _URL = "http://gateway.marvel.com/";
        private const string _publicKey = "a7bb72def8bdcf1bc554e0ee2c857557";
        private const string _privateKey = "e8f33ba2abfebc8cd6e17b3d73e43f6fd1c4b97d";

        private static string CreateMD5(string input)
        {
            var hash = String.Empty;
            using (MD5 md5Hash = MD5.Create())
            {
                byte[] bytesEntrada = new UTF8Encoding().GetBytes(input);
                byte[] bytesHash = md5Hash.ComputeHash(bytesEntrada);

                //Convertiendo array de bytes a string hexadecimal
                StringBuilder constructorStrings = new StringBuilder();
                for (int i = 0; i < bytesHash.Length; i++)
                {
                    constructorStrings.Append(bytesHash[i].ToString());
                }
                return hash.ToString();
            }
        }

        public async static Task<Root> SearchMarvelCharacters(int limit = 100, int offset = 1)
        {
            string url = GetFormatedUrl($"/v1/public/characters?limit={limit}&offset={offset}");
            HttpClient client = new HttpClient();

            var response = await client.GetAsync(url);
            var serializer = new DataContractJsonSerializer(typeof(Root));
            var result = await response.Content.ReadAsStringAsync();
            var ms = new MemoryStream(Encoding.UTF8.GetBytes(result));
            var data = (Root)serializer.ReadObject(ms);

            return data;
        }

        //llenar Dto

        private static string GetFormatedUrl(string url)
        {
            string result = string.Empty;
            var ts = GetTimestamp();
            result = $"{_URL}{url}&apikey={_publicKey}&ts={ts}&hash={CreateMD5(ts + _privateKey + _publicKey)}";

            return result;
        }

        private static String GetTimestamp()
        {
            var origin = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            var diff = DateTime.UtcNow - origin;
            return Math.Floor(diff.TotalSeconds).ToString(CultureInfo.InvariantCulture);
        }
    }
}
