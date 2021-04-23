namespace CalastoneCode
{
		public class FilterWordsContainsVowel : IFilter
		{
				public bool Filter(string text)
				{
						return HasVowelInTheMiddle(text);
				}

				private bool HasVowelInTheMiddle(string text)
				{
						if (!string.IsNullOrEmpty(text))
						{
								char[] vowel = { 'a', 'e', 'i', 'o', 'u' };

								var middle = text.Length / 2;
								var textArray = text.ToLower().ToCharArray();

								foreach (var ch in vowel)
								{
										if (text.Length > 2) // Assumption: I am only interested in words that has 3 or more letters i.e. "was" [w][a][s] ([a] is a vowel and its in the  middle)
										{
												if (textArray[middle - 1] == ch || (textArray[middle] == ch && text.Length >= 3))
												{
														return true;
												}
										}
								}
						}
						return false;
				}
		}
}