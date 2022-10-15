namespace Strings.Solutions;

public class StrongPassword
{
    public static int Run(int n, string password)
    {
        // Return the minimum number of characters to make the password strong
        int strongCharLength = 4;
        int minCharLength = 6;

        int remainderCharLenght = minCharLength - n;

        bool isLower = password.Any(p => char.IsLower(p));
        bool isUpper = password.Any(p => char.IsUpper(p));
        bool isDigit = password.Any(p => char.IsDigit(p));
        bool isSpecial = password.Any(p => !char.IsLetterOrDigit(p));

        if (isLower) strongCharLength--;
        if (isUpper) strongCharLength--;
        if (isDigit) strongCharLength--;
        if (isSpecial) strongCharLength--;

        if (strongCharLength > remainderCharLenght)
            return strongCharLength;

        return remainderCharLenght;
    }
}
