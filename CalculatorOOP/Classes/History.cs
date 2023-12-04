using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorOOP.Classes
{
    public class History
    {

        List<string> histories = new List<string>();

        public void AddHistory(string operation)
        {
            histories.Add(operation);
            
        }
        
        public void Show()
        {
            foreach (var history in histories)
            {
                Console.WriteLine(history);
            }
        }
            
    }
}
