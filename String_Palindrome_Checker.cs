// Palindrome check program
// Author: Himanshu Patel (Meerut, Uttar Pradesh)

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        string n = "Madam";
        string rev = "";
        string b = n;
        for(int i = n.Length - 1; i >=0;i--)
        {
            rev += n[i];
        }
        if(b.ToLower() == rev.ToLower())
        {
            Console.WriteLine("palindrome");
        }
        else 
        {
            Console.WriteLine("not palindrome");
        }
    }
}