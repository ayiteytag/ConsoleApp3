using System;

public class Program
{
    static void Main(string[] args)
    {/*
        bool boolFromStr = bool.Parse("true");
        int intFromStr = int.Parse("100");
        double dblFromStr = double.Parse("1.234");

        string strVal = dblFromStr.ToString();
        Console.WriteLine($"Data type : {strVal.GetType()}");
        double dblNum = 12.345;
        Console.WriteLine($"Integer : {(int)dblNum}");
        int intNum = 10;
        long longNum = intNum;
        */

        /*
        Console.WriteLine("Currency : {0:c}", 23.455);
        Console.WriteLine("Pad with 0s : {0:d4}", 23);
        Console.WriteLine("3 decimals : {0:f}", 23.45566);
        Console.WriteLine("Commas : {0:n4}", 2300);
        */

        string randString = "This is a string";
        Console.WriteLine("String Length  : {0}",
            randString.Length);
        Console.WriteLine("String Contains is  : {0}",
            randString.Contains("is"));
        Console.WriteLine("Index of is  : {0}",
            randString.IndexOf("is"));
        Console.WriteLine("Remove String  : {0}",
            randString.Remove(10, 6));
        Console.WriteLine("Insert String  : {0}",
            randString.Insert(10, "short"));
        Console.WriteLine("Replace String : {0}",
            randString.Replace("string", "sentence"));
        Console.WriteLine("Compare A to B  : {0}",
            String.Compare("A", "B",
            StringComparison.OrdinalIgnoreCase));
        Console.WriteLine("-----------------");
        Console.WriteLine("A = a : {0}",
            String.Equals("A", "a",
            StringComparison.OrdinalIgnoreCase));
        Console.WriteLine("Pad Left : {0}",
            randString.PadLeft(20, '.'));
        Console.WriteLine("Pad Right : {0}",
           randString.PadRight(20, '.'));
        Console.WriteLine("Trim : {0}",
           randString.Trim());
        Console.WriteLine("Uppercase : {0}",
           randString.ToUpper());
        Console.WriteLine("Lowercase : {0}",
           randString.ToLower());
        string newString = String.Format("{0} saw a {1} {2} {3}",
            "Paul", "rabbit", "eating", "field");
        Console.Write(newString + "\n");
        // \' \" \\ \t \a
        Console.WriteLine(@"Exactly what I typed\n");
    }
}