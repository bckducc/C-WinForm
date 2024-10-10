using Microsoft.VisualBasic;
using System.Xml.Linq;

class Xe
{
    protected string myname;
}

class Xe_Toyota : Xe
{
    public void MyName()
    {
        myname = "Toi la Toyota";
    }

    public void WHO()
    {
        Console.WriteLine("Hello, " + myname);
    }
}

class Xe_Dream : Xe
{
    public void MyName()
    {
        myname = "Toi la Dream";
    }
    public void WHO()
    {
        Console.WriteLine(myname);
    }
}

class Xe_Spacy : Xe
{
    public void MyName()
    {
        myname = "Toi la Toyota";
    }

    public void WHO()
    {
        Console.WriteLine(myname);
    }
}

class Xe_BMW : Xe
{
    public void MyName()
    {
        myname = "Toi la Toyota";
    }

    public void WHO()
    {
        Console.WriteLine(myname);
    }
}

class Xe_FIat : Xe
{
    public void MyName()
    {
        string myname = "Toi la Toyota";
    }

    public void WHO()
    {
        Console.WriteLine(myname);
    }
}

class Xe_DuLich : Xe
{
    public void MyName()
    {
        myname = "Toi la Toyota";
    }

    public void WHO()
    {
        Console.WriteLine(myname);  
    }
}

class Xe_May : Xe
{
    public void MyName()
    {
        myname = "Toi la Toyota";
    }

    public void WHO()
    {
        Console.WriteLine(myname);
    }
}

class Tester
{
    static void Main(string[] args)
    {
        Xe_Toyota a = new Xe_Toyota();
        a.WHO();
    }
}