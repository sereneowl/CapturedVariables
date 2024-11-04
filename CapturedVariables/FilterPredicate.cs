namespace CapturedVariables;

internal sealed class FilterPredicate(int wordLength)
{
   public bool Match(string item)
      => item.Length <= wordLength;
}