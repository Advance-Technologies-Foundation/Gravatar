using System;
using Gravatar;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Gravatar.Tests
{
	[TestClass]
	public class HashGeneratorTests
	{
		[TestMethod]
		public void TestHashGenerator() {
			var hashGenerator = new HashGenerator();
			var expectedGravatarHash = "20cedf4914228778ca8ae16044e2d290";
			Assert.AreEqual(expectedGravatarHash, hashGenerator.CalculateMD5Hash("v.nikonov@tscrm.com"));
		}
	}
}
