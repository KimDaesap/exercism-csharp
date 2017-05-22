using System;

public static class Bob
{
    public static string Hey(string statement)
    {
        if (statement.ToUpper().Equals(statement) &&
         !statement.ToLower().Equals(statement)) return  "Whoa, chill out!";
        else if (statement.Trim().EndsWith("?")) return "Sure.";
        else if (string.IsNullOrEmpty(statement.Trim())) return "Fine. Be that way!";
        else return "Whatever.";
    }
}