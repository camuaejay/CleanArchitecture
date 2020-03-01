namespace Data.SqlCommandFactories.Interfaces
{
    using Infrastructure.Models.Requests;
    using System;
	using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.Text;
	public interface IUserCommandFactory
	{
		SqlCommand InsertUser(RegisterUserRequest request);
	}
}
