namespace Infrastructure.Helpers
{
    using Infrastructure.Providers;
    using Microsoft.Extensions.Configuration;
	using System;
	using System.Collections.Generic;
    using System.Security.Cryptography;
    using System.Text;

	public class EncryptionHelper
	{
		private SecurityProvider securityProvider;
		private string salt;

		public EncryptionHelper(SecurityProvider securityProvider)
		{
			this.securityProvider = securityProvider;
			this.salt = this.securityProvider.pwsalt;
		}

		public string Encrypt(string password) {
			var unencrypted = password;
			var hash = MD5.Create();
			var bytes = hash.ComputeHash(Encoding.ASCII.GetBytes(this.salt+password));
			var encrypted = BitConverter.ToString(bytes);
			var result = encrypted.Replace("-", "");

			return result;
		}
	}
}
