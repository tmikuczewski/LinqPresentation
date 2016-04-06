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
			System.Console.WriteLine($"Where [NoLINQ]: {watch.ElapsedMilliseconds}ms");
			#endregion

			#region | LINQ |
			watch = System.Diagnostics.Stopwatch.StartNew();

			//var whereL = school.Students.Where(s => (s.ClassId >= 10) && (s.ClassId <= 30));

			watch.Stop();
			System.Console.WriteLine($"Where [LINQ]: {watch.ElapsedMilliseconds}ms");
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

			// sumL = school.Teachers.Sum(t => t.EmploymentDate?.Year ?? 0);

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

			#region | Max |
			int maxNL = -1, maxL = -1;

			#region | NoLINQ |
			watch = System.Diagnostics.Stopwatch.StartNew();

			foreach (var student in school.Students)
			{
				if (student.ClassId.HasValue && (student.ClassId.Value > maxNL))
				{
					maxNL = (int)student.ClassId.Value;
				}
			}

			watch.Stop();
			System.Console.WriteLine($"Max [NoLINQ]: {watch.ElapsedMilliseconds}ms");
			#endregion

			#region | LINQ |
			watch = System.Diagnostics.Stopwatch.StartNew();

			maxL = (int)school.Students.
				Where(s => s.ClassId.HasValue).
				Max(x => x.ClassId.Value);

			watch.Stop();
			System.Console.WriteLine($"Max [LINQ]: {watch.ElapsedMilliseconds}ms");
			#endregion

			System.Console.WriteLine($"Max: {maxNL} vs. {maxL}");
			#endregion

			#region | Select |

			#region | NoLINQ |
			watch = System.Diagnostics.Stopwatch.StartNew();



			watch.Stop();
			System.Console.WriteLine($"Select [NoLINQ]: {watch.ElapsedMilliseconds}ms");
			#endregion

			#region | LINQ |
			watch = System.Diagnostics.Stopwatch.StartNew();

			

			watch.Stop();
			System.Console.WriteLine($"Select [LINQ]: {watch.ElapsedMilliseconds}ms");
			#endregion

			// System.Console.WriteLine($"Select: {0} vs. {0}");
			#endregion  //empty

			#region | OrderBy |

			#region | NoLINQ |
			watch = System.Diagnostics.Stopwatch.StartNew();



			watch.Stop();
			System.Console.WriteLine($"OrderBy [NoLINQ]: {watch.ElapsedMilliseconds}ms");
			#endregion

			#region | LINQ |
			watch = System.Diagnostics.Stopwatch.StartNew();



			watch.Stop();
			System.Console.WriteLine($"OrderBy [LINQ]: {watch.ElapsedMilliseconds}ms");
			#endregion

			// System.Console.WriteLine($"OrderBy: {0} vs. {0}");
			#endregion

			#region | GroupBy |

			#region | NoLINQ |
			watch = System.Diagnostics.Stopwatch.StartNew();



			watch.Stop();
			System.Console.WriteLine($"GroupBy [NoLINQ]: {watch.ElapsedMilliseconds}ms");
			#endregion

			#region | LINQ |
			watch = System.Diagnostics.Stopwatch.StartNew();

			//var groupByL = school.Students.
			//	Where(s => s.ClassId.HasValue).
			//	GroupBy(s => s.ClassId.Value.IsEven());

			// foreach (var group in groupByL)
			// {
			// 	System.Console.WriteLine("IsEven = {group.Key}:");
			// 
			// 	foreach (var value in group)
			// 	{
			// 		System.Console.Write($"{value} ");
			// 	}
			// 
			// 	System.Console.WriteLine(string.Empty);
			// }

			watch.Stop();
			System.Console.WriteLine($"GroupBy [LINQ]: {watch.ElapsedMilliseconds}ms");
			#endregion

			// System.Console.WriteLine($"GroupBy: {0} vs. {0}");
			#endregion

			#region | Skip |

			#region | NoLINQ |
			watch = System.Diagnostics.Stopwatch.StartNew();



			watch.Stop();
			System.Console.WriteLine($"Skip [NoLINQ]: {watch.ElapsedMilliseconds}ms");
			#endregion

			#region | LINQ |
			watch = System.Diagnostics.Stopwatch.StartNew();



			watch.Stop();
			System.Console.WriteLine($"Skip [LINQ]: {watch.ElapsedMilliseconds}ms");
			#endregion

			// System.Console.WriteLine($"Skip: {0} vs. {0}");
			#endregion

			#region | Take |

			#region | NoLINQ |
			watch = System.Diagnostics.Stopwatch.StartNew();



			watch.Stop();
			System.Console.WriteLine($"Take [NoLINQ]: {watch.ElapsedMilliseconds}ms");
			#endregion

			#region | LINQ |
			watch = System.Diagnostics.Stopwatch.StartNew();



			watch.Stop();
			System.Console.WriteLine($"Take [LINQ]: {watch.ElapsedMilliseconds}ms");
			#endregion

			// System.Console.WriteLine($"Take: {0} vs. {0}");
			#endregion

			#region | Any |

			#region | NoLINQ |
			watch = System.Diagnostics.Stopwatch.StartNew();



			watch.Stop();
			System.Console.WriteLine($"Any [NoLINQ]: {watch.ElapsedMilliseconds}ms");
			#endregion

			#region | LINQ |
			watch = System.Diagnostics.Stopwatch.StartNew();



			watch.Stop();
			System.Console.WriteLine($"Any [LINQ]: {watch.ElapsedMilliseconds}ms");
			#endregion

			// System.Console.WriteLine($"Any: {0} vs. {0}");
			#endregion

			#region | Reverce |

			#region | NoLINQ |
			watch = System.Diagnostics.Stopwatch.StartNew();

			

			watch.Stop();
			System.Console.WriteLine($"Reverce [NoLINQ]: {watch.ElapsedMilliseconds}ms");
			#endregion

			#region | LINQ |
			watch = System.Diagnostics.Stopwatch.StartNew();



			watch.Stop();
			System.Console.WriteLine($"Reverce [LINQ]: {watch.ElapsedMilliseconds}ms");
			#endregion

			// System.Console.WriteLine($"Reverce: {0} vs. {0}");
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
