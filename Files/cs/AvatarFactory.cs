using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Gravatar
{
	public static class AvatarFactory
	{

		private static bool InternetConnectionExist() {
			var existsRequest = WebRequest.Create("http://bpmonline.com");
			try {
				return ((HttpWebResponse)existsRequest.GetResponse()).StatusCode == HttpStatusCode.OK;
			} catch {
				return false;
			}
		}

		public static Avatar CreateAvatarByEmail(string email) {
			if (InternetConnectionExist()) {
				return new Gravatar(email);
			} else {
				return new LocalAvatar(email);
			}
		}
	}
}
