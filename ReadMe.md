# WCCIT - Car Garage
Help the WCCIT - Car Garage is in trouble!

Their latest developer just quit and has left them in a bind. Their long time client is coming to drop off his car and expects a receipt.

The current application has been setup with a Car class but has no methods for accessing the properties and the receipt just looks like it might be code!

The main program currently only has the prompt questions and is currently not storing anything.

User Stories to Follow:

- As a User I want to be able to save my Car's make so that WCCI can have an accurate record of my property
- As a User I want to be able to save my Car's model so that WCCI can have an accurate record of my property
- As a User I want to be able to save my Car's fuel level so that WCCI can have an accurate record of my property
- As a User I want to be able to save my Car's auto brake status so that WCCI can have an accurate record of my property

## The Car Class
The Car class has been created for you. It currently only contains properties but no methods to set or get their values. 

&emsp;1. Add Getters and Setters so that the Car's properties can be accessed.

&emsp;2. Modify the return statement of the overridden ToString method so that the properties can be displayed on the receipt.

## Car Tests Project
The Car Tests, an XUnit project was also left behind. From what we can tell the previous developer was at least using Test Driven Development (TDT). Normally in a TDT environment you would be expected to write a test before writing any production code. Since you are a novice developer it should be used give you clues about what kinds of methods to expect within the Car class. 

### BUT WAIT!

Apparently the previous developer was also a noob because they completely forgot about writing tests for the getters.

&emsp;1. Add methods to the CarTests class that will test your getters. 

HINT: 

Remember that for the tests you write, your Act is going to be testing a getter method. That means that your Act is going to have to store the retrieved value and then Assert on that stored value.

## The Program Class
The main program for the WCCI Car Garage was built but not completed by their previous developer.

&emsp;1. Complete the areas of code using your newly created Getters and Setters

&emsp;2. Ensure that the receipt is now printing correctly

## Grading
A Passing grade will be based on the following criteria:
- Your completed work has been pushed up to the GitHub Classroom repository before the deadline.
- Your application runs and fulfills the user Stories
- Car Tests have been completed and all project tests pass