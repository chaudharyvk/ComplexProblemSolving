using System.Diagnostics;

[DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
internal class Program
{
    private static void Main(string[] args)
    {
        TwoSum twoSum = new TwoSum();
        MergeSort1.MergeSort([6,5,4,9,12,1],0,5);
        
    }

    private string GetDebuggerDisplay()
    {
        return ToString();
 
    }
}
