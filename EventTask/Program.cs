public delegate void Func(string str);

class MyClass
{
    public string Text { get; set; }
    public MyClass(string str)
    {
        Text = str;
    }

    public void Space(string str)
    {
        for (int i = 0; i < str.Length; i++)
        {
            Console.Write(str[i] + "_");
        }
        Console.WriteLine();
    }

    public void Reverse(string str)
    {
        for (int i = str.Length - 1; i >= 0; i--)
        {
            Console.Write(str[i]);
        }
        Console.WriteLine();
    }
}

class Run
{
    public void runFunc(Func func, string str)
    {
        func.Invoke(str);
    }
}

namespace EventTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string: ");
            string str = Console.ReadLine();

            MyClass mc = new MyClass(str);
            Func func = new Func(mc.Space);
            func += mc.Reverse;

            Run run = new Run();
            run.runFunc(func, str);
        }
    }
}