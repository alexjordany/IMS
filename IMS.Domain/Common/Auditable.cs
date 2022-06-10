using System;
namespace IMS.Domain.Common
{
	public class Auditable
	{
		public string? CreatedBy { get; set; }
		public DateTime CreatedDate { get; set; }
		public string? LastModifiedBy { get; set; }
		public DateTime LastModifiedDate { get; set; }
	}
}

