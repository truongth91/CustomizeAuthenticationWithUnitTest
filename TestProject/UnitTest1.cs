using CustomizeAuthentication.Helpers;
using System;
using Xunit;

namespace TestProject
{
	public class UnitTest1
	{
		[Fact]
		public void userNameOnlyContainNormalLetter_ReturnFalse()
		{
			string UserName = "_test001";
			bool res = StringHelper.isUserNameAvailable(UserName);

			Assert.True(!res);
		}

		[Fact]
		public void userNameOnlyContainNormalLetter_ReturnTrue()
		{
			string UserName = "test001";
			bool res = StringHelper.isUserNameAvailable(UserName);

			Assert.True(!res);
		}
	}
}
