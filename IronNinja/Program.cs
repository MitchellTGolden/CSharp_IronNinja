using System;
using IronNinja.Models;


namespace IronNinja
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome Ladies and Gentelman to a battle of the buldge(ing-stomach) that is!");
            Console.WriteLine("What you're about to witness is a battle of endurance, or as the french say endurance.");

            SweetTooth mitchell = new SweetTooth();
            Console.WriteLine("Our first contestant is the SweetTooth: Mitchell Golden, weighing in at a unflattering amount due to the one the only COVID-NINE*fadeway* TEEEEEENNNNNN");
            SpiceHound adrien = new SpiceHound();
            Console.WriteLine("For our second contender we have the SpiceHound: Adrien... DION!");
            Console.WriteLine("Let's Feast.");


            Buffet daBuffet = new Buffet();

            while (mitchell.IsFull == false && adrien.IsFull == false)
            {
                mitchell.Consume(daBuffet.Serve());
                adrien.Consume(daBuffet.Serve());

            }

            if (mitchell.ConsumptionHistory.Count == adrien.ConsumptionHistory.Count)
            {
                Console.WriteLine($"Could you believe it ladies and gentleman we have a TIE! Both Adrien and Mitchell have consumed {mitchell.ConsumptionHistory.Count} items!");
            }

            else if (mitchell.ConsumptionHistory.Count > adrien.ConsumptionHistory.Count)
            {
                Console.WriteLine($"And the winner is Mitchell consuming a whopping {mitchell.ConsumptionHistory.Count} items!");
            }
            else
            {
                Console.WriteLine($"And the winner is Adrien consuming a whopping {adrien.ConsumptionHistory.Count} items!");
            }



        }
    }
}
