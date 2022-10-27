using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionMoodAnalyser
{
    public class MoodAnalyser
    {
        public string message;
        public MoodAnalyser()
        {
            this.message = "i am in SAD mood";

        }

        public MoodAnalyser(string message)
        {
            this.message = message.ToUpper();
        }
        public string AnalyseMood()
        {

            try
            {
                if (message.ToLower().Contains("sad"))
                    return "SAD";


                else return "HAPPY";
            }
            catch (NullReferenceException)
            {

                return "HAPPY";
            }


        }
        public string AnalyseMoodWithoutConstructor(string message)
        {
            if (message.ToLower().Contains("sad"))
                return "SAD";

            else return "HAPPY";

        }
    }
}
