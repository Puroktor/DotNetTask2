namespace DotNetTask2
{
    class WordCounter
    {
        public static Dictionary<string, int> CountWordsInFile(string filename)
        {
            var wordQuantityDictionary = new Dictionary<string, int>();
            using var reader = new StreamReader(filename);
            while (!reader.EndOfStream)
            {
                var words = reader.ReadLine().Split(' ');
                foreach (var word in words)
                {
                    int wordQuntity = wordQuantityDictionary.GetValueOrDefault(word, 0);
                    wordQuantityDictionary[word] = wordQuntity + 1;
                }
            }
            return wordQuantityDictionary;
        }
    }
}
