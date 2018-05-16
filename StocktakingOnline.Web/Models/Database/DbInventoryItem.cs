﻿using System;
using Dapper;
namespace StocktakingOnline.Web.Models.Database
{
	[Table("InventoryItems")]
	public class DbInventoryItem
	{
		[Key]
		[Required]
		public string RecordId { get; set; }
		public string ProductId { get; set; }
		public decimal Quantity { get; set; }
		public int JobId { get; set; }
		public int UserId { get; set; }
		public string ImageFiles { get; set; }
		public DateTime CreatedTime { get; set; }
	}

	[Table("InventoryItems")]
	public class DbInventoryItem_ImageFiles
	{
		[Key]
		[Required]
		public string RecordId { get; set; }
		public string ImageFiles { get; set; }
	}
}
