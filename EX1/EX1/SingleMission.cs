using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    public class SingleMission : IMission
    {
        // The name of the mission
        public string Name { get; private set; }

        // The type of the mission - Composed
        public string Type { get; private set; }

        public event EventHandler<double> OnCalculate;

        // A delegate of a function to activate when calculating
        private Function function;

        public SingleMission(Function function, string name)
        {
            // The mission's function
            this.function = function;
            // The name of the mission
            this.Name = name;
            // The type of the mission is Single
            this.Type = "Single";
        }

        public double Calculate(double value)
        {
            // Get the value - result - of activating the delegate with the given value
            value = this.function(value);
            // If the OnCalculate isn't null, invoke all of them with this instance and the result value
            this.OnCalculate?.Invoke(this, value);
            // Return the result of the calculating
            return value;
        }
    }
}
