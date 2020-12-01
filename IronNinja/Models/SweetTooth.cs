using System;
using System.Collections.Generic;

namespace IronNinja.Models
{

    public class SweetTooth : Ninja
    {
        // provide override for IsFull (Full at 1500 Calories)
        public override bool IsFull
        {
            get
            {
                if (calorieIntake >= 1500)
                {
                    Console.WriteLine("It appears that you've overdone it and can no longer eat.");
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public override void Consume(IConsumable item)
        {
            if (!IsFull)
            {
                {
                    Console.WriteLine(item.GetInfo());
                    ConsumptionHistory.Add(item);
                    if (item.IsSweet)
                    {
                        int newCal = item.Calories + 10;
                        calorieIntake += newCal;

                        Console.WriteLine("Twas' a sweet one.");
                        Console.WriteLine($"Current Calories: {this.calorieIntake}");
                    }
                    else
                    {
                        calorieIntake += item.Calories;
                        Console.WriteLine($"Current Calories: {this.calorieIntake}");
                    }
                }
            }
        }
    }

}