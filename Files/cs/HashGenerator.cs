using System.Security.Cryptography;
using System.Text;

namespace Gravatar
{
	public class HashGenerator
	{
		public string CalculateMD5Hash(string input) {
			MD5 md5 = MD5.Create();
			byte[] inputBytes = Encoding.ASCII.GetBytes(input);
			byte[] hash = md5.ComputeHash(inputBytes);
			StringBuilder sb = new StringBuilder();
			for (int i = 0; i < hash.Length; i++) {
				sb.Append(hash[i].ToString("x2"));
			}
			return sb.ToString();
		}
	}
}