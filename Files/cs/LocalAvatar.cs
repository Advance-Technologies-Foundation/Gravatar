using System.IO;

namespace Gravatar
{
	internal class LocalAvatar : Avatar
	{
		private string userEmail;

		internal LocalAvatar(string email) {
			userEmail = email;
		}

		private string GetImagePath() {
			var userEmailWithoutDomain = userEmail.Split('@')[0];
			return $"C:\\ACCELERATE\\Images\\{userEmailWithoutDomain}.jpg";
		}

		public override byte[] GetImage() {
			var imageFilePath = GetImagePath();
			try {
				return File.ReadAllBytes(imageFilePath);
			} catch {
				return null;
			}
		}
	}
}