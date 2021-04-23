using CalastoneCode;
using Xunit;

namespace CalastoneCodeTests
{
		public class FilterOutWordContainsTcharTests
		{
				private readonly FilterOutWordContainsTchar _filterOutWordContainsTchar;
				public FilterOutWordContainsTcharTests()
				{
						_filterOutWordContainsTchar = new FilterOutWordContainsTchar();
				}

				#region FilterOutWordContainsTchar Test

				[Fact]
				public void FilterOutWordContainsTchar_WhenWordContainsLetterTReturnTrue()
				{
						//Arrange
						var word = "The";

						//Act
						var result = _filterOutWordContainsTchar.Filter(word);

						//Assert
						Assert.True(result);
				}
				[Fact]
				public void FilterOutWordContainsTchar_WhenWordDoesNotContainLetterTReturnFalse()
				{
						//Arrange
						var word = "was";

						//Act
						var result = _filterOutWordContainsTchar.Filter(word);

						//Assert
						Assert.False(result);
				}
				#endregion
		}
}
