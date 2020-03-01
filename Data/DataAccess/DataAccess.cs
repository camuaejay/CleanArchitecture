namespace Data.DataAccess
{
	using Infrastructure.Models.Responses;
    using Infrastructure.Providers;
    using System;
	using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.Text;
	using System.Threading.Tasks;

	public class DataAccess : IDataAccess
	{
		private ConnectionProvider connectionProvider;
		private SqlTransaction trans;
		private string dbConn;

		public async Task<DataAccessReponse> ExecuteNonReaderAsync(SqlCommand command)
		{
			DataAccessReponse response = new DataAccessReponse();

			try
			{
				using (var conn = new SqlConnection(dbConn))
				{
					conn.Open();

					using (this.trans = conn.BeginTransaction())
					{

						command.Connection = conn;
						command.Transaction = trans;

						var result = await command.ExecuteNonQueryAsync();

						trans.Commit();
						response.Success = true;
						response.Message = $"Succefully executed non query : {command.CommandText} ";
					}

					conn.Close();
				}
			}
			catch (Exception ex)
			{
				trans.Rollback();
				response.Success = false;
				response.Errors.Add(ex.Message);
				response.Message = $"Failed to execute non query : {command.CommandText} ";
			}

			return response;
		}

		public async Task<DataAccessReponse> ExecuteReaderAsync(SqlCommand command)
		{
			DataAccessReponse response = new DataAccessReponse();

			try
			{
				using (var conn = new SqlConnection(dbConn))
				{
					conn.Open();

					using (this.trans = conn.BeginTransaction())
					{

						command.Connection = conn;
						command.Transaction = trans;

						var result = await command.ExecuteReaderAsync();

						trans.Commit();
						response.Success = true;
						response.Message = $"Succefully executed non query : {command.CommandText} ";
					}

					conn.Close();
				}
			}
			catch (Exception ex)
			{
				trans.Rollback();
				response.Success = false;
				response.Errors.Add(ex.Message);
				response.Message = $"Failed to execute query : {command.CommandText} ";
			}

			return response;
		}
	}
}
