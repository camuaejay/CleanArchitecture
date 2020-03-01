namespace Infrastructure.Models.Responses
{
	using System;
	using System.Collections.Generic;
	using System.Text;

	public class DataAccessReponse : BaseResponse
	{
		public DataAccessReponse() {
			this.Success = false;
			this.Errors = new List<string>();
			this.Message = string.Empty;
		}
	}
}
