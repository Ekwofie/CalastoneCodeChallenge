using System;
using System.Collections.Generic;
using System.IO;

namespace DataRepository
{
    public class DataRepositoryService : IDataRepository
    {
        public List<string> ReadData()
        {
            var data = new List<string>();

            using (var reader = new StreamReader(Path.Combine(Environment.CurrentDirectory, "calastoneTextInput.txt")))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    foreach (var word in line.Split(new[] { ' ', '\t', '\'', '-', ':', ',', '!', '?', '"', ';', '—', '‘', '’', ',', ')', '(', '.' })) //could be improve using: Regex); 
                    {
												if (!string.IsNullOrWhiteSpace(word))
												{
                            data.Add(word);
                        }                        
                    }
                }
            }
            return data;
        }
    }
}
