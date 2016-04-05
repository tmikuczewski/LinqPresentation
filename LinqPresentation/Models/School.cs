using System.Collections.Generic;

namespace LinqPresentation.Models
{
	public class School
	{
		public ICollection<People.Student> Students { get; set; } = new List<People.Student>();
		public ICollection<People.Teacher> Teachers { get; set; } = new List<People.Teacher>();
	}
}
