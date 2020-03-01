using Data.SqlCommandFactories.Interfaces;
using Infrastructure.Models.Requests;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Data.SqlCommandFactories
{
	public class UserCommandFactory : IUserCommandFactory
	{
		public SqlCommand InsertUser(RegisterUserRequest request)
		{
			var command = new SqlCommand("InsertUser")
			{
				CommandType = CommandType.StoredProcedure,
				CommandTimeout = 300
			};

			return command;
		}
	}
}
