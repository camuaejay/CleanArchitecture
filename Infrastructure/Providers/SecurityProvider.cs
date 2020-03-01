namespace Infrastructure.Providers
{
    using Microsoft.Extensions.Configuration;
    using System;
	using System.Collections.Generic;
	using System.Text;

	public class SecurityProvider
	{
		private IConfiguration configuration;

		public string pwsalt { get; set; }
		public SecurityProvider(IConfiguration configuration)
		{
			this.configuration = configuration;
			this.pwsalt = this.configuration.GetValue<string>("Security:5alt");
		}
	}
}
