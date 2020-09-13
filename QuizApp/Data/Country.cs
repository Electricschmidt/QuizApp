using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizApp
{
    public class Country
    {
        public string Name { get; }
        public string Cap { get; }
        
        //some kind of image reference type for the flag bit?
    
        public Country(string name, string cap)
        {
            this.Name = name;
            this.Cap = cap;
        }
    }
}
