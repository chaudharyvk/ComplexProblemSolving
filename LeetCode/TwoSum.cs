using System.Diagnostics;

[DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
public class TwoSum
{
    public TwoSum()
    {
        Console.WriteLine("TwoSum");
    }

    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}