using System;
using System.Collections.Generic;

namespace IronNinja.Models
{
    public class SpiceHound : Ninja
    {
        public override bool IsFull
        {
            get
            {
                if (calorieIntake >= 1200)
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
        // provide override for IsFull (Full at 1200 Calories)
        public override void Consume(IConsumable item)
        {
            if (!IsFull)
            {
                {
                    Console.WriteLine(item.GetInfo());
                    ConsumptionHistory.Add(item);
                    if (item.IsSpicy)
                    {
                        int newCal = item.Calories - 5;
                        calorieIntake += newCal;

                        Console.WriteLine("Twas' a spicy one.");
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