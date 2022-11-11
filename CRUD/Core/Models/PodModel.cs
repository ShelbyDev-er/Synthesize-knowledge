using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
	public class PodModel
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public int Price { get; set; }
		public bool IsDeleted { get; set; }
	}
}
