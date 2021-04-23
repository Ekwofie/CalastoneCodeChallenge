using CalastoneCode;
using DataRepository;
using Moq;
using System.Collections.Generic;
using Xunit;

namespace CalastoneCodeTests
{
		public class FilterServiceTest
		{
				#region FilterService Test

				[Fact]
				public void FilterData_WhenDataIsGivenFilterOut_WordsContainsVowel_WordLessThanThreeLetters_WordContainsTchar_ReturnTrue()
				{
						//Arrange
						var data = new List<string>() { "testing", "the", "filters", "functionalities", "hopefully", "it", "passed", "clean" };
						var mockDataRepository = new Mock<IDataRepository>();
						mockDataRepository.Setup(x => x.ReadData()).Returns(data);
						var filterService = new FilterService(mockDataRepository.Object);

						var word = "passed";

						//Act
						filterService.FilterData(new FilterWordsContainsVowel());
						filterService.FilterData(new FilterOutLessThanThreeLettersWord());
						filterService.FilterData(new FilterOutWordContainsTchar());

						var result = filterService.FilteredWords[0];

						//Assert
						Assert.Equal(word, result);
				}

				#endregion
		}
}
