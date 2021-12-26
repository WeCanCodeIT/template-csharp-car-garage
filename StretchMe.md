# WCCI - Car Garage
## Stretch Tasks

As you know the previous developer left us in quite the bind. Now that you've gotten us back on track, do you think you can help us enhance our system?

- We need a way to specify who the car belongs to, probably a Car property, and it also needs to print on the receipt
- We need to expand the garage, so we need you to add a Garage class that will keep track of all our cars
- Once we have bigger storage for our cars, we will need a professional program menu so that we can choose to add a car or remove a car from our garage

## Features

- The main WCCI Car Garage Program will now offer a main menu to either add a car or remove a car
- The managers at WCCI Car Garage can now specify the owner of a car and print out a receipt.

## Hints

- The Garage class should have a property whose data type value is a list of cars, i.e. List\<Car\>
- The Garage class should have a method to add a car whose code should contain the majority of the code that is in the Program class  at the end of the main ReadMe
- The easiest way to build your application would be to add a Menu method to the Garage class so that you can use the sample stretch task code that is currently commented out of the Program class.
    - The Garage Menu should contain a loop similar to the sample code that displays the options for the Garage.
- Creating a method to iterate through the list of cars and return not just the user's choice but the actual car will be very helpful. Refer to the Sample Code for the best way to implement the menu feature.

## Sample Code

```chsarp
public Car ChooseCar()
{
    for(int i=1; i < listOfCars.Count; i++)
    {
        Console.WriteLine(i + ". " + listOfCars[i-1].GetMake() + ", listOfCars[i-1].GetModel());
    }

    int userChoice = Convert.ToInt32(Console.ReadLine());
    
    return listOfCars[userChoice-1];
}
