using System;

namespace LinqPresentation.Models.People
{
	public class Teacher : Base.Person
	{
		public Teacher(string firstName, string lastName, DateTime? birthDate, DateTime? employmentDate = null)
			: base(firstName, lastName, birthDate)
		{
			this.EmploymentDate = employmentDate;
		}

		public override string ToString() => $"[Teacher] {base.ToString().Replace("[Person] ", string.Empty)} (ed: {this.EmploymentDate})";
		public override int GetHashCode() => (this.ToString().GetHashCode());
		public override bool Equals(object obj) => ((obj is Teacher) && ((obj as Teacher).GetHashCode() == this.GetHashCode()));

		public DateTime? EmploymentDate { get; }
	}
}
