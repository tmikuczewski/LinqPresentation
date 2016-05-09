using System;

namespace LinqPresentation.Models.Base
{
	public abstract class Person
	{
		public Person(string firstName, string lastName, DateTime? birthDate = null)
		{
			this.FirstName = firstName;
			this.LastName = lastName;
			this.BirthDay = birthDate;
		}

		public override string ToString() => $"[Person] {this.FirstName} {this.LastName} {this.BirthDay}";
		public override int GetHashCode() => (this.ToString().GetHashCode());
		public override bool Equals(object obj) => ((obj is Person) && ((obj as Person).GetHashCode() == this.GetHashCode()));

		public string FirstName { get; set; }
		public string LastName { get; set; }
		public DateTime? BirthDay { get; set; }
	}
}
