namespace CapturedVariables;

internal sealed class FilterPredicate(int wordLength)
{
   readonly int valueToCompare = wordLength;
   public bool Match(string item)
      => item.Length <= valueToCompare;
}