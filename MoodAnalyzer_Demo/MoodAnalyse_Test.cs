using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer_Demo
{
    public class MoodAnalyse_Test
    {
        public string AnalyseMood(string massage)
        {
            //my name is sad 
            if (massage.Contains("Sad"))
            {
                return "Sad";
            }
            else
            {
                return "Happy";
            }
        }
    }
}
