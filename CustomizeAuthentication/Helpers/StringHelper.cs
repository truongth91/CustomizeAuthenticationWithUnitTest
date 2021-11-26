using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CustomizeAuthentication.Helpers
{
	public class StringHelper
	{
		/// <summary>
		/// Method verify UserName format: required only text A-Z a-z 0-9
		/// </summary>
		/// <param name="UserName"></param>
		/// <returns></returns>
		public static bool isUserNameAvailable(string UserName)
		{
			Regex regex = new Regex(@"[A-Za-z0-9]");
			MatchCollection matches = regex.Matches(UserName);
			return matches.Count.Equals(UserName.Length);
		}
	}
}
