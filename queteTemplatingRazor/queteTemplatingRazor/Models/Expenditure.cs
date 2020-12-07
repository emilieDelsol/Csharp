using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace queteTemplatingRazor.Models
{
	public class Expenditure
	{
		public String spentName { get; set; }
		public DateTime spentDate { get; set; }
		public Int32 spentPrice { get; set; }

	}
}
