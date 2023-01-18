using hanojska_vez;

class Program
{
    
    //Main není potřeba,ale rád ho používám
    static void Main(string[] args)
    {
        VezHanoi tower = new VezHanoi();
        int n = 7;
        Console.WriteLine("Solving Tower of Hanoi with " + n + " discs");
        tower.Vyres(n);
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}