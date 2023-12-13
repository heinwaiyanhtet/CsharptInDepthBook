partial class Program{

    static partial void PartialMethod();

}


partial class Program{
    static partial void PartialMethod()
    {
        Console.WriteLine("hello");
    }
}

partial class Program{
    static void Main(){

        Console.WriteLine("Hello from part 1");
        PartialMethod();

    }
}