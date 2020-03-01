namespace Infrastructure.Providers
{
    using Microsoft.Extensions.Configuration;
    using System;
	using System.Collections.Generic;
	using System.Text;

	public class ConnectionProvider
	{
		private IConfiguration configuration;

		public string ConnectionString { get; set; }

		public ConnectionProvider(IConfiguration configuration)
		{
			this.configuration = configuration;
			this.ConnectionString = this.configuration.GetValue<string>("Connections:DBConn");
		}
	}
}
