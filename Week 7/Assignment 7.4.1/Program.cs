namespace Assignment_7._4._1 {
    internal class Program {
        /*
        Design a parking system for a parking lot. The parking lot has three
        kinds of parking spaces: big, medium, and small, with a fixed number
        of slots for each size. Implement the ParkingSystem class:
        **ParkingSystem(int big, int medium, int small) Initializes object of
        the ParkingSystem class. The number of slots for each parking space
        are given as part of the constructor.
        **bool addCar(int carType) Checks whether there is a parking space of
        carType for the car that wants to get into the parking lot. carType
        can be of three kinds: big, medium, or small, which are represented
        by 1, 2, and 3 respectively. A car can only park in a parking space
        of its carType. If there is no space available, return false, else
        park the car in that size space and return true.
        --- Example ---
        - Input
        ["ParkingSystem", "addCar", "addCar", "addCar", "addCar"]
        [[1, 1, 0], [1], [2], [3], [1]]
        - Output
        [null, true, true, false, false]
        - Explanation
        ParkingSystem parkingSystem = new ParkingSystem(1, 1, 0);
        // return true because there is 1 available slot for a big car
        parkingSystem.addCar(1); 
        // return true because there is 1 available slot for a medium car
        parkingSystem.addCar(2); 
        // return false because there is no available slot for a small car
        parkingSystem.addCar(3); 
        // return false because there is no available slot for a big car.
        parkingSystem.addCar(1); 
        */
        static void Main(string[] args) {
            Console.WriteLine("Hello, World!\n");
            // parkingLot[0] = Big, parkingLot[1] = Med, parkingLot[2] = Small
            int[] parkingLot = new int[] { 1, 1, 0 };

            // case one
            int carOne = 1;
            Console.WriteLine("One big car is coming.");
            ParkingAttendant(parkingLot, carOne);
            Console.WriteLine("-------------------------");
            // case two: one med car coming
            int carTwo = 2;
            Console.WriteLine("One medium car is coming.");
            ParkingAttendant(parkingLot, carTwo);
            Console.WriteLine("-------------------------");
            //case three: one small car coming
            int carThree = 3;
            Console.WriteLine("One small car is coming.");
            ParkingAttendant(parkingLot, carThree);
            Console.WriteLine("-------------------------");
            // case four: one big car coming
            int carFour = 1;
            Console.WriteLine("One big car is coming.");
            ParkingAttendant(parkingLot, carFour);
        }

        static int[] ParkingAttendant(int[] parkingLot, int incomingCar) {
            bool isSpotOpen = false;
            for (int i = 0; i < parkingLot.Length; i++) {
                if (parkingLot[incomingCar - 1] > 0) {
                    isSpotOpen = true;
                    parkingLot[incomingCar - 1] -= 1;
                }
            }

            Console.WriteLine($"{(isSpotOpen ? "A" : "No")} parking spot was found.");
            return parkingLot;
        }
    }
}
/*
This assignment was a lot simpler than i had anticipated. my whiteboard had a lot of
extra steps i didnt need, including a list, a dictionary, and enum of cars... all
pointless for the most part, had to redo a lot of it from scratch, but it followed
the same path of logic in the end...
*/