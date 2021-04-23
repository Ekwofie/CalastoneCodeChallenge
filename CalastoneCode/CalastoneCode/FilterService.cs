using DataRepository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CalastoneCode
{
		public class FilterService
		{
				public List<string> FilteredWords { get; }

				public FilterService(IDataRepository dataRepository)
				{
						FilteredWords = dataRepository?.ReadData() ?? throw new ArgumentNullException(nameof(dataRepository));
				}

				public void FilterData(IFilter applyFilter)
				{
						if (applyFilter != null)
						{
								foreach (var word in FilteredWords.ToList())
								{
										if (applyFilter.Filter(word))
										{
												FilteredWords.Remove(word);
										}
								}
						}
				}

				public void DisplayFilteredTexts()
				{
						foreach (var word in FilteredWords)
						{
								Console.WriteLine(word);
						}
				}
		}
}
