string[] wordsArray = {"test1", "test2", "one", "on", "work", "coh"};
Console.WriteLine(string.Join(", ", wordsArray.Where(x => x.Length <= 3)));