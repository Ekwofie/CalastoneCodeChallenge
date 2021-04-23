using DataRepository;

namespace CalastoneCode
{
		class Program
		{
				static void Main(string[] args)
				{
						var filterService = new FilterService(new DataRepositoryService());
						
						filterService.FilterData(new FilterWordsContainsVowel());
						filterService.FilterData(new FilterOutLessThanThreeLettersWord());
						filterService.FilterData(new FilterOutWordContainsTchar());

						filterService.DisplayFilteredTexts();
				}
		}
}
