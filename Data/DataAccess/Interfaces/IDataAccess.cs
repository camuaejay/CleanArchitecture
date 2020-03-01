namespace Data.DataAccess
{
    using Infrastructure.Models.Responses;
    using System;
	using System.Collections.Generic;
    using System.Data;
    using System.Data.SqlClient;
    using System.Text;
    using System.Threading.Tasks;

    public interface IDataAccess
	{
		Task<DataAccessReponse> ExecuteReaderAsync(SqlCommand command);
		Task<DataAccessReponse> ExecuteNonReaderAsync(SqlCommand command);
    }
}
