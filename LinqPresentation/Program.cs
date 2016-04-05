using System.Linq;

using LinqPresentation.Models;

namespace LinqPresentation
{
	class Program
	{
		static void Main(string[] args)
		{
			School school = new School();

			#region | Loading |

			var watch = System.Diagnostics.Stopwatch.StartNew();

			Utilities.Utils.LoadPeopleFromCsv(ref school);

			watch.Stop();
			System.Console.WriteLine($"Loading: {watch.ElapsedMilliseconds}ms");

			#endregion

			#region | Where |

			#region | NoLINQ |
			watch = System.Diagnostics.Stopwatch.StartNew();

			//var whereNL = new System.Collections.Generic.List<Models.People.Student>();
			//foreach (var student in school.Students)
			//{
			//	if ((student.ClassId >= 10) && (student.ClassId <= 30))
			//	{
			//		whereNL.Add(student);
			//	}
			//}

			watch.Stop();
			System.Console.WriteLine($" [NoLINQ]: {watch.ElapsedMilliseconds}ms");
			#endregion

			#region | LINQ |
			watch = System.Diagnostics.Stopwatch.StartNew();

			//var whereL = school.Students.Where(s => (s.ClassId >= 10) && (s.ClassId <= 30));

			watch.Stop();
			System.Console.WriteLine($" [LINQ]: {watch.ElapsedMilliseconds}ms");
			#endregion

			//System.Console.WriteLine($"Where: {whereNL.Count} vs. {whereL.Count()}");
			#endregion

			#region | Sum |
			int sumNL, sumL;

			#region | NoLINQ |
			watch = System.Diagnostics.Stopwatch.StartNew();

			//sumNL = 0;
			//foreach (var teacher in school.Teachers)
			//{
			//	sumNL += teacher.EmploymentDate?.Year ?? 0;
			//}

			watch.Stop();
			System.Console.WriteLine($"Sum [NoLINQ]: {watch.ElapsedMilliseconds}ms");
			#endregion

			#region | LINQ |
			watch = System.Diagnostics.Stopwatch.StartNew();

			#region | Case 01 |

			//sumL = school.Teachers.Sum(t => t.EmploymentDate?.Year ?? 0);

			#endregion
			#region | Case 02 |

			//sumL = school.Teachers.
			//	Where(t => t.EmploymentDate.HasValue).
			//	Sum(x => x.EmploymentDate.Value.Year);

			#endregion

			watch.Stop();
			System.Console.WriteLine($"Sum [LINQ]: {watch.ElapsedMilliseconds}ms");
			#endregion

			//System.Console.WriteLine($"Sum: {sumNL} vs. {sumL}");
			#endregion

			#region |  |

			#region | NoLINQ |
			watch = System.Diagnostics.Stopwatch.StartNew();



			watch.Stop();
			System.Console.WriteLine($" [NoLINQ]: {watch.ElapsedMilliseconds}ms");
			#endregion

			#region | LINQ |
			watch = System.Diagnostics.Stopwatch.StartNew();



			watch.Stop();
			System.Console.WriteLine($" [LINQ]: {watch.ElapsedMilliseconds}ms");
			#endregion

			// System.Console.WriteLine($": {0} vs. {0}");
			#endregion
		}
	}
}
