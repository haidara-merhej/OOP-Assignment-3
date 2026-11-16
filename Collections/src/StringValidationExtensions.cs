using System.Text.RegularExpressions;

namespace Collections;

public static class StringValidationExtensions
{
    public static bool IsValidEgyptianPhone(this string? value)
    {
        if(string.IsNullOrEmpty(value))
            return false;

        return Regex.IsMatch(value, @"^(01[0125]\d{8})|\+20(10|11|12|15)\d{8}$");
    }

    public static bool IsValidEgyptianNationalId(this string? value)
    {
        if(string.IsNullOrEmpty(value))
            return false;

        return Regex.IsMatch(value, @"^[23]\d{13}$");
    }
}

