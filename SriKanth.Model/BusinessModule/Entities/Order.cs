﻿using SriKanth.Model.BusinessModule.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SriKanth.Model.BusinessModule.Entities
{
	public class Order
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int OrderNumber { get; set; }
		public string CustomerCode { get; set; }
		public string LocationCode { get; set; }
		public DateTime OrderDate { get; set; }
		public OrderStatus Status { get; set; } // Pending, Completed, Rejected
		public decimal TotalAmount { get; set; }
		public string SalesPersonCode { get; set; }
		public string PaymentMethodCode { get; set; }
		public string? Note { get; set; }
		public string? RejectReason { get; set; }
		public string? TrackingNumber { get; set; }
		public string? DelivertPersonName { get; set; }
		public DateOnly? DeliveryDate { get; set; }

	}
	public enum OrderStatus
	{
		Pending,
		Processing,
		Delivered,
		Rejected
	}

}
