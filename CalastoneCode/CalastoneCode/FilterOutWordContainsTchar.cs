namespace CalastoneCode
{
		public class FilterOutWordContainsTchar : IFilter
		{
				public bool Filter(string text)
				{
						if (!string.IsNullOrEmpty(text))
						{
								return text.ToLower().Contains('t');
						}
						return false;
				}
		}
}
