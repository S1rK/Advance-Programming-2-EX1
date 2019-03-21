using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    public class ComposedMission : IMission
    {
        // The name of the mission
        public string Name { get; private set; }

        // The type of the mission - Composed
        public string Type { get; private set; }

        public event EventHandler<double> OnCalculate;

        // A delegate of functions to activate when calculating
        private Function functions;

        // Constuctor
        public ComposedMission(string name)
        {
            // The name of the mission
            this.Name = name;
            // The type of the mission is Composed
            this.Type = "Composed";
        }

        public ComposedMission Add(Function function)
        {
            // Add the function to the delegate
            this.functions += function;
            // Return this reference
            return this;
        }

        public double Calculate(double value)
        {
            // Go over the fucntions, send them the result of the previous function
            foreach (Function f in this.functions.GetInvocationList())
            {
                value = f(value);
            }
            // If the OnCalculate isn't null, invoke all of them with this instance and the result value
            this.OnCalculate?.Invoke(this, value);
            // Return the result of the calculating
            return value;
        }
    }
}
