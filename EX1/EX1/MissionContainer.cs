using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{

    public delegate double Function(double x);

    public class FunctionsContainer
    {
        // A dictionary between string - name of a function, and the function itself
        private Dictionary<string, Function> functionsDictionary;

        // Constructor
        public FunctionsContainer()
        {
            // Initialize the dictionary
            this.functionsDictionary = new Dictionary<string, Function>();
        }

        public Function this[string name]
        {
            get
            {
                // If trying to get a function named "Stam" and there isn't one in the dictionary
                if (name == "Stam" && !this.functionsDictionary.ContainsKey("Stam"))
                    // Add one that returns the value itself: Stam(x)=x
                    this.functionsDictionary.Add("Stam", (double val) => { return val; });
                // Return the function with that name in the dictionary
                return this.functionsDictionary[name];
            }
            set
            {
                // If there is already a function with that name, override her
                if (this.functionsDictionary.ContainsKey(name))
                    this.functionsDictionary[name] = value;
                else
                    // Else, add to the dictionary the function with that name
                    this.functionsDictionary.Add(name, value);
            }
        }

        public List<string> getAllMissions()
        {
            // Return the dictionary's keys as a string list
            return new List<string>(this.functionsDictionary.Keys);
        }

    }
}
