using System.Net;

namespace Gravatar
{
	public class Gravatar: Avatar {
		private string hash;

		internal Gravatar(string email) {
			var hashGenerator = new HashGenerator();
			hash = hashGenerator.CalculateMD5Hash(email);
		}

		private string GetGravatarImageUri() {
			return $"http://gravatar.com/avatar/{hash}";
		}

		private string GetGravatarExistsUri() {
			return $"http://gravatar.com/exist/{hash}";
		}

		private bool ExistsImage() {
			var existsRequest = WebRequest.Create(GetGravatarExistsUri());
			try {
				return ((HttpWebResponse)existsRequest.GetResponse()).StatusCode == HttpStatusCode.OK;
			} catch {
				return false;
			}
		}

		public override byte[] GetImage() {
			byte[] result = null;
			if (ExistsImage()) {
				var uri = GetGravatarImageUri();
				using (WebClient webClient = new WebClient()) {
					result = webClient.DownloadData(uri);
				}
			}
			return result;
		}
	}
}