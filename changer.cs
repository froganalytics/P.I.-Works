class Int_Swap
{
    static void Main(string[] args)
    {
        Console.Write("First number?");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Second number?");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Before change, a = " a + "\n and b = " + b);
        Change(ref a, ref b);
        Console.WriteLine("After change, a = " a + "\n and b = " + b);
    }

    static void Change(ref int a, ref int b)
    {
        //-----------------------ACTUAL ALGORITHM-----------------------------------
        // int a = 1;
        // int b = 2;
        int a = a + b; // a = 1 + 2
        int b = a - b; // b = 3 - 2
        int a = a - b; // a = 3 - 1
        //---------------------------------------------------------------------------
    }
}
