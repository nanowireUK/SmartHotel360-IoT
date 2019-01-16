﻿namespace SmartHotel.Services.FacilityManagement.Models
{
	public class AuthFlow
	{
		public bool UseAdalAuthFlow => SimpleAuthOptions == null
									   || string.IsNullOrWhiteSpace( SimpleAuthOptions.ApiKey )
									   || string.IsNullOrWhiteSpace( SimpleAuthOptions.ApplicationId )
									   || string.IsNullOrWhiteSpace( SimpleAuthOptions.ApplicationSecret )
									   || string.IsNullOrWhiteSpace( SimpleAuthOptions.TenantId );
		public SimpleAuthOptions SimpleAuthOptions { get; set; }
	}
}