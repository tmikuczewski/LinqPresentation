using System.Linq;

using LinqPresentation.Models;
using LinqPresentation.Utilities;

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

			//#region | NoLINQ |
			//watch = System.Diagnostics.Stopwatch.StartNew();

			//var whereNL = new System.Collections.Generic.List<Models.People.Student>();
			//foreach (var student in school.Students)
			//{
			//	if ((student.ClassId >= 10) && (student.ClassId <= 30))
			//	{
			//		whereNL.Add(student);
			//	}
			//}

			//watch.Stop();
			//System.Console.WriteLine($"Where [NoLINQ]: {watch.ElapsedMilliseconds}ms");
			//#endregion

			//#region | LINQ |
			//watch = System.Diagnostics.Stopwatch.StartNew();

			//var whereL = school.Students.Where(s => (s.ClassId >= 10) && (s.ClassId <= 30));

			//watch.Stop();
			//System.Console.WriteLine($"Where [LINQ]: {watch.ElapsedMilliseconds}ms");
			//#endregion

			//System.Console.WriteLine($"Where: {whereNL.Count} vs. {whereL.Count()}");
			#endregion

			#region | Sum |
			//int sumNL, sumL;

			//#region | NoLINQ |
			//watch = System.Diagnostics.Stopwatch.StartNew();

			//sumNL = 0;
			//foreach (var teacher in school.Teachers)
			//{
			//	sumNL += teacher.EmploymentDate?.Year ?? 0;
			//}

			//watch.Stop();
			//System.Console.WriteLine($"Sum [NoLINQ]: {watch.ElapsedMilliseconds}ms");
			//#endregion

			//#region | LINQ |
			//watch = System.Diagnostics.Stopwatch.StartNew();

			//#region | Case 01 |

			//sumL = school.Teachers.Sum(t => t.EmploymentDate?.Year ?? 0);

			//#endregion
			//#region | Case 02 |

			//sumL = school.Teachers.
			//	Where(t => t.EmploymentDate.HasValue).
			//	Sum(x => x.EmploymentDate.Value.Year);

			//#endregion

			//watch.Stop();
			//System.Console.WriteLine($"Sum [LINQ]: {watch.ElapsedMilliseconds}ms");
			//#endregion

			//System.Console.WriteLine($"Sum: {sumNL} vs. {sumL}");
			#endregion

			#region | Max |
			//int maxNL = -1, maxL = -1;

			//#region | NoLINQ |
			//watch = System.Diagnostics.Stopwatch.StartNew();

			//foreach (var student in school.Students)
			//{
			//	if (student.ClassId.HasValue && (student.ClassId.Value > maxNL))
			//	{
			//		maxNL = (int)student.ClassId.Value;
			//	}
			//}

			//watch.Stop();
			//System.Console.WriteLine($"Max [NoLINQ]: {watch.ElapsedMilliseconds}ms");
			//#endregion

			//#region | LINQ |
			//watch = System.Diagnostics.Stopwatch.StartNew();

			//maxL = (int)school.Students.
			//	Where(s => s.ClassId.HasValue).
			//	Max(x => x.ClassId.Value);

			//watch.Stop();
			//System.Console.WriteLine($"Max [LINQ]: {watch.ElapsedMilliseconds}ms");
			//#endregion

			//System.Console.WriteLine($"Max: {maxNL} vs. {maxL}");
			#endregion

			#region | Select |
			//System.Collections.Generic.List<string>
			//	selectNL = new System.Collections.Generic.List<string>();

			//#region | NoLINQ |
			//watch = System.Diagnostics.Stopwatch.StartNew();

			//foreach (var teacher in school.Teachers)
			//{
			//	selectNL.Add(string.Join(",", teacher.FirstName, teacher.LastName));
			//}

			//watch.Stop();
			//System.Console.WriteLine($"Select [NoLINQ]: {watch.ElapsedMilliseconds}ms");
			//#endregion

			//#region | LINQ |
			//watch = System.Diagnostics.Stopwatch.StartNew();

			//var selectL = school.Teachers.Select(t => string.Join(",", t.FirstName, t.LastName));

			//watch.Stop();
			//System.Console.WriteLine($"Select [LINQ]: {watch.ElapsedMilliseconds}ms");
			//#endregion

			#endregion

			#region | OrderBy |

			//#region | NoLINQ |
			//watch = System.Diagnostics.Stopwatch.StartNew();



			//watch.Stop();
			//System.Console.WriteLine($"OrderBy [NoLINQ]: {watch.ElapsedMilliseconds}ms");
			//#endregion

			//#region | LINQ |
			//watch = System.Diagnostics.Stopwatch.StartNew();

			//#region ASC

			//var orderByL = school.Students.
			//	Where(s => s.BirthDay.HasValue).
			//	OrderBy(s => s.BirthDay.Value.Year);

			//#endregion

			//#region DESC

			//orderByL = school.Students.
			//	Where(s => s.BirthDay.HasValue).
			//	OrderByDescending(s => s.BirthDay.Value.Year);

			//#endregion

			//watch.Stop();
			//System.Console.WriteLine($"OrderBy [LINQ]: {watch.ElapsedMilliseconds}ms");
			//#endregion

			#endregion

			#region | GroupBy |
			//System.Collections.Generic.List<Models.People.Student>
			//	groupByNLtrue = new System.Collections.Generic.List<Models.People.Student>(),
			//	groupByNLfalse = new System.Collections.Generic.List<Models.People.Student>();

			//#region | NoLINQ |
			//watch = System.Diagnostics.Stopwatch.StartNew();

			//foreach (var student in school.Students)
			//{
			//	if (student.ClassId.HasValue)
			//	{
			//		if (student.ClassId.Value.IsEven())
			//		{
			//			groupByNLtrue.Add(student);
			//		}
			//		else
			//		{
			//			groupByNLfalse.Add(student);
			//		}
			//	}
			//}

			//watch.Stop();
			//System.Console.WriteLine($"GroupBy [NoLINQ]: {watch.ElapsedMilliseconds}ms");
			//#endregion

			//#region | LINQ |
			//watch = System.Diagnostics.Stopwatch.StartNew();

			//var groupByL = school.Students.
			//	Where(s => s.ClassId.HasValue).
			//	GroupBy(s => s.ClassId.Value.IsEven());

			//watch.Stop();
			//System.Console.WriteLine($"GroupBy [LINQ]: {watch.ElapsedMilliseconds}ms");
			//#endregion
			//
			#endregion

			#region | Skip |
			//System.Collections.Generic.List<Models.People.Teacher>
			//	skipNL = new System.Collections.Generic.List<Models.People.Teacher>();

			//#region | NoLINQ |
			//watch = System.Diagnostics.Stopwatch.StartNew();

			//int i = 5;
			//foreach (var teacher in school.Teachers)
			//{
			//	if (i-- <= 0)
			//	{
			//		skipNL.Add(teacher);
			//	}
			//}

			//watch.Stop();
			//System.Console.WriteLine($"Skip [NoLINQ]: {watch.ElapsedMilliseconds}ms");
			//#endregion

			//#region | LINQ |
			//watch = System.Diagnostics.Stopwatch.StartNew();

			//var skipL = school.Teachers.Skip(5);

			//#region | Ext |

			//skipL = school.Teachers.
			//	Where(t => t.BirthDay.HasValue).
			//	OrderBy(t => t.BirthDay.Value.Year).
			//	SkipWhile(t => t.BirthDay.Value.Year < 1980);

			//#endregion

			//watch.Stop();
			//System.Console.WriteLine($"Skip [LINQ]: {watch.ElapsedMilliseconds}ms");
			//#endregion

			#endregion

			#region | Take |
			//System.Collections.Generic.List<Models.People.Teacher>
			//	takeNL = new System.Collections.Generic.List<Models.People.Teacher>();

			//#region | NoLINQ |
			//watch = System.Diagnostics.Stopwatch.StartNew();

			//int i = 0;
			//foreach (var teacher in school.Teachers)
			//{
			//	if (i++ < 5)
			//	{
			//		takeNL.Add(teacher);
			//	}
			//	else
			//	{
			//		break;
			//	}
			//}

			//watch.Stop();
			//System.Console.WriteLine($"Take [NoLINQ]: {watch.ElapsedMilliseconds}ms");
			//#endregion

			//#region | LINQ |
			//watch = System.Diagnostics.Stopwatch.StartNew();

			//var takeL = school.Students.Take(5);

			//#region | Ext |

			//takeL = school.Students.
			//	Where(s => s.ClassId.HasValue).
			//	OrderByDescending(s => s.ClassId.Value).
			//	TakeWhile(s => s.ClassId.Value > school.Students.Average(x => x.ClassId.Value));

			//#endregion

			//watch.Stop();
			//System.Console.WriteLine($"Take [LINQ]: {watch.ElapsedMilliseconds}ms");
			//#endregion

			#endregion

			#region | Reverce |
			//System.Collections.Generic.List<Models.People.Teacher>
			//	reverceNL = new System.Collections.Generic.List<Models.People.Teacher>();

			//#region | NoLINQ |
			//watch = System.Diagnostics.Stopwatch.StartNew();

			//for (int i = school.Teachers.Count - 1; i >= 0; i--)
			//{
			//	reverceNL.Add(((System.Collections.Generic.List<Models.People.Teacher>)school.Teachers)[i]);
			//}

			//watch.Stop();
			//System.Console.WriteLine($"Reverce [NoLINQ]: {watch.ElapsedMilliseconds}ms");
			//#endregion

			//#region | LINQ |
			//watch = System.Diagnostics.Stopwatch.StartNew();

			//var reverceL = school.Teachers.Reverse();

			//watch.Stop();
			//System.Console.WriteLine($"Reverce [LINQ]: {watch.ElapsedMilliseconds}ms");
			//#endregion

			#endregion

			#region |  |

			//#region | NoLINQ |
			//watch = System.Diagnostics.Stopwatch.StartNew();



			//watch.Stop();
			//System.Console.WriteLine($" [NoLINQ]: {watch.ElapsedMilliseconds}ms");
			//#endregion

			//#region | LINQ |
			//watch = System.Diagnostics.Stopwatch.StartNew();



			//watch.Stop();
			//System.Console.WriteLine($" [LINQ]: {watch.ElapsedMilliseconds}ms");
			//#endregion

			//System.Console.WriteLine($": {0} vs. {0}");
			#endregion
		}
	}
}
