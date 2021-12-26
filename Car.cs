using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace template_csharp_car_garage
{
    public class Car
    {
        private string Make;
        private string Model;
        private int Speed;
        private int Fuel;
        private bool AutoBrakeActive;

        // Getters & Setters Go Here



        // Override ToString() method here
        public override string ToString()
        {
            // Currently this line simply returns the object type as a string
            // Modify to use your Getters and Setters
            // HINT: Use operators and the keyword 'this'
            // EXAMPLE: "Make: " + this.GetMake() + "\nModel: " + this.GetModel()
            return base.ToString();
        }
    }
}
