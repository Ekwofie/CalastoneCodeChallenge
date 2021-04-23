using CalastoneCode;
using Xunit;

namespace CalastoneCodeTests
{
		public class FilterOutLessThanThreeLettersWordTests
		{
				private readonly FilterOutLessThanThreeLettersWord _filterOutLessThanThreeLettersWord;
				public FilterOutLessThanThreeLettersWordTests()
				{
						_filterOutLessThanThreeLettersWord = new FilterOutLessThanThreeLettersWord();
				}

				#region FilterOutLessThanThreeLettersWord Test

				[Fact]
				public void FilterOutLessThanThreeLettersWord_WhenWordHasLessThanThreeLettersReturnTrue()
				{
						//Arrange
						var word = "She";

						//Act
						var result = _filterOutLessThanThreeLettersWord.Filter(word);

						//Assert
						Assert.True(result);
				}

				[Fact]
				public void FilterOutLessThanThreeLettersWord_WhenWordHasMoreThanThreeLettersReturnFalse()
				{
						//Arrange
						var word = "what";

						//Act
						var result = _filterOutLessThanThreeLettersWord.Filter(word);

						//Assert
						Assert.False(result);
				}

				#endregion
		}
}
