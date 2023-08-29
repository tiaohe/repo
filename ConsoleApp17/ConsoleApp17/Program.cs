// See https://aka.ms/new-console-template for more information

// Console.WriteLine("Hello, World!");
interface IMyInterface
{
    void MethodToImplement();
}

class InterfaceImplementer : IMyInterface
{
    public void MethodToImplement()
    {
        Console.WriteLine("MethodToImplement() called.");
    }
}

interface IParentInterface
{
    void ParentInterfaceMethod();
}

interface ImyInterface : IParentInterface
{
    void MethodToImplement();
}

class Interface : ImyInterface
{
    private ImyInterface _imyInterfaceImplementation;

    static void Main()
    {
        InterfaceImplementer iImp = new InterfaceImplementer();
        iImp.MethodToImplement();
    }

    public void ParentInterfaceMethod()
    {
        _imyInterfaceImplementation.ParentInterfaceMethod();
    }

    public void MethodToImplement()
    {
        _imyInterfaceImplementation.MethodToImplement();
    }
}
