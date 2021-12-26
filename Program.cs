using System;

namespace template_csharp_car_garage
{
    class Program
    {
        static void Main(string[] args)
        {
            string m1 = "Welcome to the WCCI Car Garage\n\n";
            string m2 = "What is the make of the car you are storing with us?\n";
            string m3 = "What is the model of the car you are storing with us?\n";
            string m4 = "What is the car's current fuel level? (0-100)\n";
            string m5 = "Is the auto brake active on this car?\n";

            // Declaration of a new object must include 3 parts
            // DataType | Variable Name | new DataType()
            Car wcciCar = new Car();

            Console.WriteLine(m1);
            Console.WriteLine(m2);

            // CODE TO STORE MAKE GOES HERE

            Console.WriteLine(m3);

            // CODE TO STORE MODEL GOES HERE

            Console.WriteLine(m4);
            
            // CODE TO SET FUEL LEVEL GOES HERE
            
            Console.WriteLine(m5);

            // CODE TO SET AUTO BRAKE VALUE

            // Here is where we print the receipt
            Console.WriteLine("\nCar Receipt\n");
            Console.WriteLine(wcciCar.ToString());

            // SAMPLE CODE FOR STRETCH ME TASKS

            //Garage wcciGarage = new Garage();
            //bool showMenu = true;
            //while (showMenu)
            //{
            //    Console.Clear();
            //    Console.WriteLine("Welcome to the WCCI - Car Garage System Menu\n\n");
            //    Console.WriteLine("Choose from the following options");
            //    Console.WriteLine("1. Run the WCCI Garage");
            //    Console.WriteLine("2. Quit");

            //    int userChoice = Convert.ToInt32(Console.ReadLine());
            //    switch (userChoice)
            //    {
            //        case 1:
            //            showMenu = wcciGarage.Menu();
            //            break;
            //        case 2:
            //            showMenu = false;
            //            break;
            //        default:
            //            break;
            //    }
            // }

        }
    }
}
