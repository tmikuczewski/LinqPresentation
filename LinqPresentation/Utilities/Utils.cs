using System;

namespace LinqPresentation.Utilities
{
	public static class Utils
	{
		public static void LoadPeopleFromCsv(ref Models.School school)
		{
			using (var reader = new System.IO.StreamReader(System.IO.File.OpenRead("../../Files/FNG.csv"), System.Text.Encoding.Default, true))
			{
				while (!reader.EndOfStream)
				{
					var row = reader.ReadLine().Split(',');

					DateTime date = DateTime.Parse(row[2], new System.Globalization.CultureInfo("en-US"));

					if ((DateTime.Today.Year - date.Year) <= 25)
					{
						school.Students.Add(new Models.People.Student(row[0], row[1], date, RandomClassId()));
					}
					else
					{
						school.Teachers.Add(new Models.People.Teacher(row[0], row[1], date, RandomEmploymentDate(date.Year)));
					}
				}
			}
		}

		private static uint RandomClassId(int classesCount = 100) => ((uint)random.Next(classesCount));

		private static DateTime RandomEmploymentDate(int birthYear)
		{
			return
				new DateTime(
					DateTime.Today.Year - (DateTime.Today.Year - birthYear - 25),
					random.Next(1, 13),
					1
				);
		}

		private static Random random = new Random();
	}
}
