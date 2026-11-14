using Architecture_CODS;
using System;
using System.Collections.Generic;

enum Flapjackcs
{
    Crispy,
    Soggy,
    Browned,
    Banana,

}
class Lumberijack
{
    public string Name;
    private Stack<Flapjackcs> flapiJackStack = new Stack<Flapjackcs>();

    public Lumberijack(string name)
    {
        Name = name;
       
    }
    public void TakeFlapjack(Flapjackcs flapjackcs)
    {
        flapiJackStack.Push(flapjackcs);
    }

    public void EatFlapjacks()
    {
        Console.WriteLine($"{Name} is eating flapjacks");
        while (flapiJackStack.Count > 0  )
        {
            Console.WriteLine($"{Name} ate a {flapiJackStack.Pop().ToString().ToLower()} flapjack");
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
    Random random = new Random();
        Queue<Lumberijack> lumberijacks = new Queue<Lumberijack>();
        string name;
        Console.WriteLine("First lumberjack's name: ");
        while ((name = Console.ReadLine()) != "")
        {
            Console.WriteLine("Number of flapjacks:");
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                Lumberijack lumberijack = new Lumberijack(name);
                for (int i = 0; i < number; i++)
                {
                    lumberijack.TakeFlapjack((Flapjackcs)random.Next(0, 4));
                }
                lumberijacks.Enqueue (lumberijack);
            }
           while (lumberijacks.Count > 0)
            {
                Lumberijack next = lumberijacks.Dequeue();
                next.EatFlapjacks();
            }
        }
        
    }
}
