using System.Collections.Generic;

using LinqPresentation.Models.People;

namespace LinqPresentation.Models
{
	public class School
	{
		public ICollection<Student> Students { get; set; } = new List<Student>();
		public ICollection<Teacher> Teachers { get; set; } = new List<Teacher>();
	}
}
