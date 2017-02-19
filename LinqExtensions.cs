public static class LinqExtensions
{
	
	public static IEnumerable<T> Yield(this T value)
	{
		yield return value;
	}
}