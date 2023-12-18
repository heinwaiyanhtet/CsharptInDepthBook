using System.Dynamic;

class Program
{
    static void Main(){

        dynamic expando = new ExpandoObject();
        expando.someData = "Some data";

        Action<string> action = input 
            =>
        Console.WriteLine("here is input '{0}'",input); 

        expando.FakeMethod = action;

        Console.WriteLine(expando.someData);

        expando.FakeMethod("hello");
    
        IDictionary<string,object> dictionary = expando;

        Console.WriteLine("keys: {0}",string.Join(",",dictionary.Keys));

        dictionary["otherData"] = "other";
        
        Console.WriteLine(expando.otherData);

    }
}