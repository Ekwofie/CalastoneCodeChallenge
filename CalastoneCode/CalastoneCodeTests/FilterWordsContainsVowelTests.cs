using CalastoneCode;
using Xunit;

namespace CalastoneCodeTests
{
		public class FilterWordsContainsVowelTests
		{
				private readonly FilterWordsContainsVowel _filterWordsContainsVowel;

				public FilterWordsContainsVowelTests()
				{
						_filterWordsContainsVowel = new FilterWordsContainsVowel();
				}

				#region FilterWordsContainsVowel Test
				[Fact]
				public void FilterWordsContainsVowel_WhenStringIsEmptyReturnFalse()
				{
						//Arrange
						var word = "";

						//Act
						var result = _filterWordsContainsVowel.Filter(word);

						//Assert
						Assert.False(result);
				}

				[Fact]
				public void FilterWordsContainsVowel_WhenStringIsNullReturnFalse()
				{
						//Arrange
						string word = null;

						//Act
						var result = _filterWordsContainsVowel.Filter(word);

						//Assert
						Assert.False(result);
				}

				[Fact]
				public void FilterWordsContainsVowel_WhenWordContainsVowelInTheMiddleReturnTrue()
				{
						//Arrange
						var word = "currently";

						//Act
						var result = _filterWordsContainsVowel.Filter(word);

						//Assert
						Assert.True(result);
				}

				[Fact]
				public void FilterWordsContainsVowel_WhenWordContainsVowelAtTheEndOfTheWordReturnFalse()
				{
						//Arrange
						var word = "the";

						//Act
						var result = _filterWordsContainsVowel.Filter(word);

						//Assert
						Assert.False(result);
				}
				#endregion
		}
}
