namespace CapturedVariables;

internal sealed class ListFilter
{
   public static IList<T> Filter<T>(IList<T> source, Predicate<T> predicate)
   {
      var filteredList = new List<T>();
      foreach (T item in source)
      {
         if (predicate(item))
         {
            filteredList.Add(item);
         }
      }

      return filteredList;
   }

   public static void PrintList<T>(IList<T> source)
   {
      foreach (T item in source)
      {
         Console.WriteLine(item);
      }
   }
}