﻿using System;
using StocktakingOnline.Web.Models.Domain;
namespace StocktakingOnline.Web.Models.ViewModel
{
	public class InventoryViewModel
	{
		public Job CurrentJob { get; set; }
		public AddInventoryItemViewModel AddInventoryItemViewModel { get; set; }
		public InventoryItem LastAddedInventoryItem { get; set; }
		public bool ShowAddSuccessedText { get; set; }
	}
}
