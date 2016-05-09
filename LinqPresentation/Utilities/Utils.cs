using System;
using System.Globalization;
using System.IO;
using System.Text;
using System.Threading.Tasks;

using LinqPresentation.Models;
using LinqPresentation.Models.People;

namespace LinqPresentation.Utilities
{
	public static class Utils
	{
		public static void LoadPeopleFromCsv(ref School school)
		{
			using (var reader = new StreamReader(File.OpenRead("../../Files/FNG.csv"), Encoding.Default, true))
			{
				while (!reader.EndOfStream)
				{
					var row = reader.ReadLine().Split(',');

					DateTime date = DateTime.Parse(row[2], new CultureInfo("en-US"));

					if ((DateTime.Today.Year - date.Year) <= 25)
					{
						school.Students.Add(new Student(row[0], row[1], date, RandomClassId()));
					}
					else
					{
						school.Teachers.Add(new Teacher(row[0], row[1], date, RandomEmploymentDate(date.Year)));
					}
				}
			}
		}

		public static School ParallelLoadPeopleFromCsv(School school)
		{
			Parallel.ForEach(File.ReadLines("../../Files/FNG.csv"), (line) =>
			{
				var row = line.Split(',');

				DateTime date = DateTime.Parse(row[2], new CultureInfo("en-US"));

				if ((DateTime.Today.Year - date.Year) <= 25)
				{
					school.Students.Add(new Student(row[0], row[1], date, RandomClassId()));
				}
				else
				{
					school.Teachers.Add(new Teacher(row[0], row[1], date, RandomEmploymentDate(date.Year)));
				}
			});

			return school;
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
