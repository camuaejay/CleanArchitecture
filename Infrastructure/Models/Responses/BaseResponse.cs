﻿namespace Infrastructure.Models.Responses
{
	using System;
	using System.Collections.Generic;
	using System.Text;

	public class BaseResponse
	{
		public bool Success { get; set; }
		public List<string> Errors { get; set; }
		public string Message { get; set; }
	}
}
