namespace LinqPresentation.Utilities
{
	public static class Extensions
	{
		#region | Done |

		#region IsEven

		public static bool IsEven(this sbyte value) => (value % 2 == 0);
		public static bool IsEven(this byte value) => (value % 2 == 0);
		public static bool IsEven(this short value) => (value % 2 == 0);
		public static bool IsEven(this ushort value) => (value % 2 == 0);
		public static bool IsEven(this int value) => (value % 2 == 0);
		public static bool IsEven(this uint value) => (value % 2 == 0);
		public static bool IsEven(this long value) => (value % 2 == 0);
		public static bool IsEven(this ulong value) => (value % 2 == 0);

		#endregion

		#endregion
	}
}
