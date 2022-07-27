
static void Main()
{
    HelloWorld hello = new HelloWorld();
    hello.SetHello("Hello World");
    Console.WriteLine(hello.GetHello());
    Console.ReadLine();
}

public class HelloWorld
{
    private string _hello;

    public void SetHello(string hello)
    {
        _hello = hello;
    }
    public string GetHello()
    {
        return _hello;
    }
}


using System;

public class Carros
{
    string _carro;

    public ____ SetCarro(string carro)
{
    _carro = carro;
}

public string GetCarro____
{
        return _carro;
}
}