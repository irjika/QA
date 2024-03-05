string pass = Console.ReadLine();

if (IsValidPassword(pass))
{
    Console.WriteLine("Password is valid");
}
else
{
    if (pass.Length < 2 || pass.Length > 6)
    {
        Console.WriteLine("Password must be between 6 and 10 characters");
    }
    else if (pass.All(char.IsLetterOrDigit))
    {
        Console.WriteLine("Password must consist only of letters and digits");
    }
    else if (pass.Count(char.IsDigit) >= 2)
    {
        Console.WriteLine("Password must have at least 2 digits");
    }

    }


static bool IsValidPassword (string password)
{
    if (password.Length >= 6 && password.Length <= 10)
    {
        return true;
        
    }
    if (password.All(char.IsLetterOrDigit))
    {
        return true;
    }
    if (password.Count(char.IsDigit) >= 2)
    {
        return true;
    }

    return false;
}