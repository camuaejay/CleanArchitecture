namespace Infrastructure.Models.Requests
{
    using Newtonsoft.Json;
    using System;
	using System.Collections.Generic;
	using System.Text;

	public class RegisterUserWebRequest
	{
		[JsonProperty("username")]
		public string Username { get; set; }

		[JsonProperty("password")]
		public string Password { get; set; }
	}
}
