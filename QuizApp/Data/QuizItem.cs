using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizApp.Data
{
    public class QuizItem
    {
        public string QuestionCountry { get; set; }
        public string QuestionAnswer { get; set; }
        public List<string> Options = new List<string>();

        public QuizItem(List<Country> countries)
        {
            var random = new Random();
            int index = random.Next(countries.Count);
            QuestionCountry = countries[index].Name;
            QuestionAnswer = countries[index].Cap;
            Options.Add(countries[index].Cap);
            int i = 0;
            while(i < 3)
            {
                int _index = random.Next(countries.Count);
                if (Options.Contains(countries[_index].Cap) == false)
                {
                    Options.Add(countries[_index].Cap);
                    i++;
                }
            }
            Options.Shuffle();
        }
    }
}
