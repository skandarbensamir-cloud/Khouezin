using System.Reflection.Metadata.Ecma335;

namespace simplegit;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hello, Git");
        Console.WriteLine(Dosomething("skander"));
    }


    static string Dosomething(string name)
    {
        return $"Hello {name}";
    
    }

}


