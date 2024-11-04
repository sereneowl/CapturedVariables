using System.Globalization;
using CapturedVariables;

IList<string> sampleWords = ["Scream", "some", "troubling", "will", "words", "have", "specifically", "fun", "little", "sentence", "ja?"];

// 1. get all words with length smaller or equal to 4

// Predicate<string> predicate = new(MatchFourLettersOrFewer);
Predicate<string> predicate2 = item => item.Length <= 4;

IList<string> shortWords = ListFilter.Filter(sampleWords, predicate2);
ListFilter.PrintList(shortWords);

// 2. Allow the user to enter the length to filter the words by

// Console.Write("Length to filter the words by: ");
// string? readLine = Console.In.ReadLine();
// if (int.TryParse(readLine, CultureInfo.InvariantCulture, out int wordLength))
// {
//    IList<string> userWords;
   
//    Predicate<string> predicate3 = item => item.Length <= wordLength;   
//    userWords = ListFilter.Filter(sampleWords, predicate3);
//    ListFilter.PrintList(userWords);

//    Console.WriteLine("now with 5:");
//    // even though the delegate hasn't changed, it will still function correctly and display
//    // all words with length <= 5.
//    wordLength = 5;
//    userWords = ListFilter.Filter(sampleWords, predicate3);
//    ListFilter.PrintList(userWords);
// }

// Console.Write("Length to filter the words by: ");
// string? readLine = Console.In.ReadLine();
// if (int.TryParse(readLine, CultureInfo.InvariantCulture, out int wordLength))
// {
//    var filterPredicate = new FilterPredicate(wordLength);
//    IList<string> userWords;

//    userWords = ListFilter.Filter(sampleWords, filterPredicate.Match);
//    ListFilter.PrintList(userWords);

//    Console.WriteLine("now with 5:");
//    // variable, not value is captured. Aka, Filter will work as expected and get 5 values
//    wordLength = 5;
//    userWords = ListFilter.Filter(sampleWords, filterPredicate.Match);
//    ListFilter.PrintList(userWords);
// }

// Console.WriteLine("Counter: ");
// List<Action> actions = new List<Action>();
// for (int counter = 0; counter < 10; counter++)
// {
//    actions.Add(() => Console.WriteLine(counter));
// }
// foreach (Action action in actions)
// {
//    action();
// }

// DisplayObject(actions);
// DisplayObject(null);

// public void DisplayObject(object? o)
// {
//    if (o == null)
//    {
//       Console.WriteLine("null");
//    }
//    else
//    {
//       Task.Run(() => Console.WriteLine(o));
//    }
// }

// static bool MatchFourLettersOrFewer(string item)
//    => item.Length <= 4;