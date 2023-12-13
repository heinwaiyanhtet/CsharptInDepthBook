// using System;
// using System.Collections.Generic;

// class Program
// {
//     static void Main()
//     {
//         foreach (var item in GetIntegerDouble(2))
//         {
//             Console.WriteLine("Received: {0}", item);
//         }
//     }

//     static IEnumerable<int> GetIntegerDouble(int count)
//     {
//         try
//         {
//             for (int i = 0; i < count; i++)
//             {
//                 Console.WriteLine("Yielding {0}", i);
//                 yield return i;
//                 int doubled = i * 2;
//                 Console.WriteLine("Yielding {0}", doubled);
//                 yield return doubled;
//             }
//         }
//        finally
//         {
//         Console.WriteLine("In finally block");
//         }
//     }
// }

