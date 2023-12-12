using System;

class GenericCounter<T>
{
    private int value; // Not static, to make it instance-specific

    public GenericCounter()
    {
        Console.WriteLine("Initializing counter for {0}", typeof(T));
    }

    public void Increment()
    {
        value++;
    }

    public void Display()
    {
        Console.WriteLine("Counter for {0}: {1}", typeof(T), value);
    }
}

class GenericCounterDemo
{
    static void Main()
    {
        GenericCounter<string> stringCounter = new GenericCounter<string>();

        stringCounter.Increment();
        stringCounter.Increment();
        stringCounter.Display();

        GenericCounter<int> intCounter = new GenericCounter<int>();

        intCounter.Increment();
        intCounter.Display();
    }
}

// anonymous type

// var book = (title: "Lost in the Snow", author: "Holly Webb");
// Console.WriteLine(book.title); 

// Serialization and desearalization

// Copying Element from one collection to another

// static List<T> CopyAtMost<T>(List<T> input, int maxElements)
// {
//     int actualCount = Math.Min(input.Count, maxElements);

//     List<T> ret = new List<T>(actualCount);

//     for (int i = 0; i < actualCount; i++)
//     {
//         ret.Add(input[i]);
//     }

//     return ret;
// }

// static void Main()
// {
//     List<int> numbers = new List<int>();

//     numbers.Add(5);
//     numbers.Add(10);
//     numbers.Add(20);

//     List<int> firstTwo = CopyAtMost<int>(numbers, 2);

//     Console.WriteLine(firstTwo.Count); // Output: 2
// }
