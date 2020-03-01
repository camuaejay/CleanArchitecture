namespace Infrastructure.Models.Requests
{
	using System;
	using System.Collections.Generic;
	using System.Text;

	public class RegisterUserRequest
	{
		public RegisterUserRequest(RegisterUserWebRequest request) {
			this.Password = request.Password;
			this.Username = request.Username;
		}

		public string Username { get; set; }
		public string Password { get; set; }
	}
}
