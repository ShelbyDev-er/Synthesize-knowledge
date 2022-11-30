using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.DataModels
{
	[Table("PodCategories")]
	public class PodCategoryDataModel
	{
		[Key]
		public int PodCategoryId { get; set; }

		[Column("PodName", TypeName = "varchar")]
		[MaxLength(20)]
		public string Name { get; set; }
		
		public int Quantity { get; set; }

		public ICollection<PodDataModel> Pods { get; set; }
	}
}