namespace Stacks.Solutions;

public class BalancedBrackets
{
    public static string Run(string s)
    {
        var stack = new Stack<char>();

        Dictionary<char, char> charList = new();
        charList.Add('{', '}');
        charList.Add('(', ')');
        charList.Add('[', ']');

        for (int i = 0; i < s.Length; i++)
        {
            if (charList.Keys.Contains(s[i]))
                stack.Push(s[i]);

            else
            {
                if (stack.Count > 0)
                {
                    char removeChar = stack.Pop();
                    if (charList.TryGetValue(removeChar, out char c))
                    {
                        if (s[i] != c) return "NO";
                    }
                }
                else return "NO";
            }
        }
        return "YES";
    }
}
