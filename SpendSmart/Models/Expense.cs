using System;
namespace SpendSmart.Models
{
	public class Expense
	{
		public int Id { get; set; }

		public decimal Value { get; set; }

		[System.ComponentModel.DataAnnotations.Required]

		public string? Description { get; set; }
	}
}

