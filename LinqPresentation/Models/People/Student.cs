namespace LinqPresentation.Models.People
{
	public class Student : Base.Person
	{
		public Student(string firstName, string lastName, System.DateTime? birthDate, uint? classId = null)
			: base(firstName, lastName, birthDate)
		{
			this.ClassId = classId;
		}

		public override string ToString() => $"[Student] {base.ToString().Replace("[Person] ", string.Empty)} (cId: {this.ClassId})";
		public override int GetHashCode() => (this.ToString().GetHashCode());
		public override bool Equals(object obj) => ((obj is Student) && ((obj as Student).GetHashCode() == this.GetHashCode()));

		public uint? ClassId { get; set; }
	}
}
