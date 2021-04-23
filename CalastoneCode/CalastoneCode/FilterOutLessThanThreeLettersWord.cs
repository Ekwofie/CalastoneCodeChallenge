namespace CalastoneCode
{
		public class FilterOutLessThanThreeLettersWord : IFilter 
		{
				public bool Filter(string text)
				{
						return text?.Length <= 3;
				}
		}
}