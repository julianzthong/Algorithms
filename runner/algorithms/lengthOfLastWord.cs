namespace Runner.Algorithms;

public partial class Solution
{
    public int LengthOfLastWord(string s)
    {
        string[] array = s.Trim().Split(' ');
        return array[array.Length - 1].Length;
    }
}