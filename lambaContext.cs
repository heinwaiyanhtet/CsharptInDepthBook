// using System;
// using System.Collections.Generic;

// class Program
// {
//     private class LambdaContext
//     {
//         public string text;

//         public void Method(){
//             Console.WriteLine(text);
//         }
//     }


//     static void Main()
//     {
//         List<Action> actions = new List<Action>();

//         for (int i = 0; i < 5; i++)
//         {
//             LambdaContext context = new LambdaContext();
            
//             context.text = String.Format("Message {0}",i);
            
//             actions.Add(context.Method);
//         }
        
//         foreach (var action in actions)
//         {   
//             action();
//         }
//     }

// }

