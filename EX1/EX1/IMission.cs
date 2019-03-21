using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    public interface IMission
    {
        event EventHandler<double> OnCalculate;  // An Event of when a mission is activated

        String Name { get;} // A proporty of the mission's name
        String Type { get; } // A proporty of the mission's type (Single or Composed)

        double Calculate(double value); // A function to calculate the mission with a given value
    }
}
