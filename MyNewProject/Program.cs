internal class Program{

    int a = 10;
    int b = 20;

    public void addNumbers()
    {

        Console.WriteLine(a + b);

    }

    public void mulNumbers()
    {

        Console.WriteLine(a * b);
    }

    public void subNumebers()
    {
        Console.WriteLine(a - b);
    }

    public void divNumebers()
    {
        Console.WriteLine(a / b);
    }

    public void ModNumebers()
    {
        Console.WriteLine(a % b);
    }

    public static void Main(String[] args)
    {

        Program p = new Program();
        p.addNumbers();
        p.mulNumbers();
        p.divNumebers();
        p.subNumebers();
        p.ModNumebers();
    }


}