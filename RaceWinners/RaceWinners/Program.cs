using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace RaceWinners
{
    class Program
    {
       
    
        static async Task Main(string[] args)
        {
            DataService ds = new DataService();
 
            // Asynchronously retrieve the group (class) data
            var data = await ds.GetGroupRanksAsync();

            for (int i = 0; i < data.Count; i++)
            {
                // Combine the ranks to print as a list
                var ranks = String.Join(", ", data[i].Ranks);
                
                Console.WriteLine($"{data[i].Name} - [{ranks}]");
                double median;
                int numCount = ranks.Count();
                int halfIndex = ranks.Count() / 2;
                var sortRanks = ranks.OrderBy(n => n);
                if ((numCount % 2) == 0)
                {
                    median =((sortRanks.ElementAt(halfIndex)+ sortRanks.ElementAt((halfIndex -1)))/2);
                }
                else
                {
                    median = sortRanks.ElementAt(halfIndex);
                }
                Console.WriteLine(("The median is: " +median));
            }
            
        }

      
    }
    
}