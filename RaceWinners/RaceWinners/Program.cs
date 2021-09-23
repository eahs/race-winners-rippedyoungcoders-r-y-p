using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RaceWinners
{
    class Program
    {
        
        var medians = new List<Median>();

        public static getMedian()
        {
            int n = List.size;
            int Med = (n + 1) / 2; 
        }
        
        
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
            }
            
        }

      
    }
    
}