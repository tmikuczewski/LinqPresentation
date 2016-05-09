using System.Linq;
using static System.Console;
using System.Collections.Generic;

using LinqPresentation.Models;
using LinqPresentation.Utilities;
using LinqPresentation.Models.People;

namespace LinqPresentation
{
	class Program
	{
		static void Main(string[] args)
		{
			School school = new School();
			var watch = System.Diagnostics.Stopwatch.StartNew();

			#region | Loading |

			//// Utils.LoadPeopleFromCsv(ref school);
			//school = Utils.ParallelLoadPeopleFromCsv(school);

			//watch.Stop();
			//WriteLine($"Loading: {watch.Elapsed}");

			//#endregion

			//#region | Where |

			//#region | NoLINQ |
			//watch.Restart();

			//var whereNL = new System.Collections.Generic.List<Models.People.Student>();
			//foreach (var student in school.Students)
			//{
			//	if ((student.ClassId >= 10) && (student.ClassId <= 30))
			//	{
			//		whereNL.Add(student);
			//	}
			//}

			//watch.Stop();
			//WriteLine($"Where [NoLINQ]: {watch.ElapsedMilliseconds}");
			//#endregion

			//#region | LINQ |
			//watch.Restart();

			//var whereL = school.Students.Where(s => (s.ClassId >= 10) && (s.ClassId <= 30));

			//watch.Stop();
			//WriteLine($"Where [LINQ]: {watch.Elapsed}");
			//#endregion

			//WriteLine($"Where: {whereNL.Count} vs. {whereL.Count()}");
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
			//WriteLine($"Sum [NoLINQ]: {watch.Elapsed}");
			//#endregion

			//#region | LINQ |
			//watch.Restart();

			//#region | Case 01 |

			//sumL = school.Teachers.Sum(t => t.EmploymentDate?.Year ?? 0);

			//#endregion
			//#region | Case 02 |

			//sumL = school.Teachers.
			//	Where(t => t.EmploymentDate.HasValue).
			//	Sum(x => x.EmploymentDate.Value.Year);

			//#endregion

			//watch.Stop();
			//WriteLine($"Sum [LINQ]: {watch.Elapsed}");
			//#endregion

			//WriteLine($"Sum: {sumNL} vs. {sumL}");
			#endregion

			#region | Max |
			//int maxNL = -1, maxL = -1;

			//#region | NoLINQ |
			//watch.Restart();

			//foreach (var student in school.Students)
			//{
			//	if (student.ClassId.HasValue && (student.ClassId.Value > maxNL))
			//	{
			//		maxNL = (int)student.ClassId.Value;
			//	}
			//}

			//watch.Stop();
			//WriteLine($"Max [NoLINQ]: {watch.Elapsed}");
			//#endregion

			//#region | LINQ |
			//watch.Restart();

			//maxL = (int)school.Students.
			//	Where(s => s.ClassId.HasValue).
			//	Max(x => x.ClassId.Value);

			//watch.Stop();
			//WriteLine($"Max [LINQ]: {watch.Elapsed}");
			//#endregion

			//WriteLine($"Max: {maxNL} vs. {maxL}");
			#endregion

			#region | Select |
			//List<string> selectNL = new List<string>();

			//#region | NoLINQ |
			//watch.Restart();

			//foreach (var teacher in school.Teachers)
			//{
			//	selectNL.Add(string.Join(",", teacher.FirstName, teacher.LastName));
			//}

			//watch.Stop();
			//WriteLine($"Select [NoLINQ]: {watch.Elapsed}");
			//#endregion

			//#region | LINQ |
			//watch.Restart();

			//var selectL = school.Teachers.Select(t => string.Join(",", t.FirstName, t.LastName));

			//watch.Stop();
			//WriteLine($"Select [LINQ]: {watch.Elapsed}");
			//#endregion

			#endregion

			#region | OrderBy |

			//#region | NoLINQ |
			//watch.Restart();

			//// TODO

			//watch.Stop();
			//WriteLine($"OrderBy [NoLINQ]: {watch.Elapsed}");
			//#endregion

			//#region | LINQ |
			//watch.Restart();

			//#region ASC, 1 parametr

			//var orderByL = school.Students.
			//	Where(s => s.BirthDay.HasValue).
			//	OrderBy(s => s.BirthDay.Value.Year);

			//#endregion

			//#region DESC, 1 parametr

			//orderByL = school.Students.
			//	Where(s => s.BirthDay.HasValue).
			//	OrderByDescending(s => s.BirthDay.Value.Year);

			//#endregion

			//#region ASC, 2 parametry

			//orderByL = school.Students.
			//	OrderBy(s => s.FirstName).
			//	ThenBy(s => s.LastName);

			//#endregion

			//#region ASC+DESC, 2 parametry

			//orderByL = school.Students.
			//	Where(s => s.BirthDay.HasValue).
			//	OrderBy(s => s.BirthDay.Value.Year).
			//	ThenByDescending(s => s.BirthDay.Value.Month);

			//#endregion

			//watch.Stop();
			//WriteLine($"OrderBy [LINQ]: {watch.Elapsed}");
			//#endregion

			#endregion

			#region | GroupBy |
			//List<Student>
			//	groupByNLtrue = new List<Student>(),
			//	groupByNLfalse = new List<Student>();

			//#region | NoLINQ |
			//watch.Restart();

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
			//WriteLine($"GroupBy [NoLINQ]: {watch.Elapsed}");
			//#endregion

			//#region | LINQ |
			//watch.Restart();

			//var groupByL = school.Students.
			//	Where(s => s.ClassId.HasValue).
			//	GroupBy(s => s.ClassId.Value.IsEven());

			//watch.Stop();
			//WriteLine($"GroupBy [LINQ]: {watch.Elapsed}");
			//#endregion

			#endregion

			#region | Skip |
			//List<Teacher> skipNL = new List<Teacher>();

			//#region | NoLINQ |
			//watch.Restart();

			//int i = 5;
			//foreach (var teacher in school.Teachers)
			//{
			//	if (i-- <= 0)
			//	{
			//		skipNL.Add(teacher);
			//	}
			//}

			//watch.Stop();
			//WriteLine($"Skip [NoLINQ]: {watch.Elapsed}");
			//#endregion

			//#region | LINQ |
			//watch.Restart();

			//var skipL = school.Teachers.Skip(5);

			//#region | Ext |

			//skipL = school.Teachers.
			//	Where(t => t.BirthDay.HasValue).
			//	OrderBy(t => t.BirthDay.Value.Year).
			//	SkipWhile(t => t.BirthDay.Value.Year < 1980);

			//#endregion

			//watch.Stop();
			//WriteLine($"Skip [LINQ]: {watch.Elapsed}");
			//#endregion

			#endregion

			#region | Take |
			//List<Teacher> takeNL = new List<Teacher>();

			//#region | NoLINQ |
			//watch.Restart();

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
			//WriteLine($"Take [NoLINQ]: {watch.Elapsed}");
			//#endregion

			//#region | LINQ |
			//watch.Restart();

			//var takeL = school.Students.Take(5);

			//#region | Ext |

			//takeL = school.Students.
			//	Where(s => s.ClassId.HasValue).
			//	OrderByDescending(s => s.ClassId.Value).
			//	TakeWhile(s => s.ClassId.Value > school.Students.Average(x => x.ClassId.Value));

			//#endregion

			//watch.Stop();
			//WriteLine($"Take [LINQ]: {watch.Elapsed}");
			//#endregion

			#endregion

			#region | Reverce |
			//List<Teacher> reverceNL = new List<Teacher>();

			//#region | NoLINQ |
			//watch.Restart();

			//for (int i = school.Teachers.Count - 1; i >= 0; i--)
			//{
			//	reverceNL.Add((school.Teachers.ToList())[i]);
			//}

			//watch.Stop();
			//WriteLine($"Reverce [NoLINQ]: {watch.Elapsed}");
			//#endregion

			//#region | LINQ |
			//watch.Restart();

			//var reverceL = school.Teachers.Reverse();

			//watch.Stop();
			//WriteLine($"Reverce [LINQ]: {watch.Elapsed}");
			//#endregion

			#endregion

			#region |  |

			//#region | NoLINQ |
			//watch.Restart();



			//watch.Stop();
			//WriteLine($" [NoLINQ]: {watch.Elapsed}");
			//#endregion

			//#region | LINQ |
			//watch.Restart();



			//watch.Stop();
			//WriteLine($" [LINQ]: {watch.Elapsed}");
			//#endregion

			//WriteLine($": {0} vs. {0}");
			#endregion
		}
	}
}
