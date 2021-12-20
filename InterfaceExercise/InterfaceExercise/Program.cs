using System;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            var myCar = new Car()
            {
                trunkSize = "15.4 cubic ft",
                hasSpoiler = false, numWheels = 4,
                useGas = true,
                numDoor = 4,
                color = "Gold",
                nameOfCompany = "Toyota",
                americanMade = false
            };
            
            var myTruck = new Truck();
            #region myTruckValues
            myTruck.hasBed = true;
            myTruck.bedSize = "6 ft long";
            myTruck.numWheels = 4;
            myTruck.useGas = false;
            myTruck.numDoor = 2;
            myTruck.color = "red";
            myTruck.nameOfCompany = "Dodge Ram";
            myTruck.americanMade = true;
            #endregion

            var mySUV = new SUV();
            #region mySUVValues
            mySUV.awd4wd = true;
            mySUV.nineOrMoreSeats = true;
            mySUV.numWheels = 4;
            mySUV.useGas = true;
            mySUV.numDoor = 4;
            mySUV.color = "Blue";
            mySUV.nameOfCompany = "Honda";
            mySUV.americanMade = false;
            #endregion

            Console.WriteLine($"My random Car Values \n" +
                              $"Trunk Size: {myCar.trunkSize}\n" +
                              $"Does it have a Spoiler? {myCar.hasSpoiler}\n" +
                              $"Does it use gas? {myCar.useGas}\n" +
                              $"How many doors? {myCar.numDoor}\n" +
                              $"What color is it? {myCar.color}\n" +
                              $"What company made it? {myCar.nameOfCompany}\n" +
                              $"Is that an american company? {myCar.americanMade}");
            Console.WriteLine();
            Console.WriteLine($"My random Truck Values \n" +
                              $"Does the Truck have a bed? {myTruck.hasBed}\n" +
                              $"How bid is the bed?? {myTruck.bedSize}\n" +
                              $"Does it use gas? {myTruck.useGas}\n" +
                              $"How many doors? {myTruck.numDoor}\n" +
                              $"What color is it? {myTruck.color}\n" +
                              $"What company made it? {myTruck.nameOfCompany}\n" +
                              $"Is that an american company? {myTruck.americanMade}");
            Console.WriteLine();
            Console.WriteLine($"My random SUV Values \n" +
                              $"Does is have 4wd? {mySUV.awd4wd}\n" +
                              $"Does it have 9 more seats? {mySUV.nineOrMoreSeats}\n" +
                              $"Does it use gas? {mySUV.useGas}\n" +
                              $"How many doors? {mySUV.numDoor}\n" +
                              $"What color is it? {mySUV.color}\n" +
                              $"What company made it? {mySUV.nameOfCompany}\n" +
                              $"Is that an american company? {mySUV.americanMade}");



            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values
        }
    }
}
