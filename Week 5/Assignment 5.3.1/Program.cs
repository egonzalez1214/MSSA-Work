namespace Assignment_5._3._1 {

    internal class Program {

        static void Main(string[] args) {
            Console.WriteLine("Hello, World!\n");

            //case 1
            int[] flowerBed1 = { 1, 0, 0, 0, 1 }; //current flower bed
            int flowersToPlant1 = 1; //flowers to plant
            ManualFlowerBeds(flowerBed1, flowersToPlant1);

            //case 2
            int[] flowerBed2 = { 1, 0, 0, 0, 1 }; //current flower bed
            int flowersToPlant2 = 2; //flowers to plant
            ManualFlowerBeds(flowerBed2, flowersToPlant2);

            //case 3: user prompted flower bed and flower count
            UserFlowerBeds();
        }

        static void ManualFlowerBeds(int[] array, int n) {            
            //initialize flowersToPlant to not planted
            bool allPlantsGone = false;

            //visual demonstration of flower bed with flowers to plant
            for (int i = 0; i < array.Length; i++) {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine($"\nFlowers left to plant: {n}");

            //iterate through array starting index 1 and ending before last index
            for (int i = 0; i < 1; i++) {
                if (array[i] == 0 && array[i + 1] == 0) {
                    array[i] = 1; //plant a flower
                    n--; //decrease the flower count
                }
            }
            for (int i = 1; i < array.Length - 1; i++) {  
                if (array[i - 1] == 0 && array[i] == 0 && array[i + 1] == 0) {
                    array[i] = 1; //plant flower
                    n--; //decrease flower count
                }
            }

            //check if all flowers planted
            if (n <= 0) {
                allPlantsGone = true;
            }

            //visual demonstration of flower bed after flowers planted
            Console.WriteLine("-------------------------");
            for (int i = 0; i < array.Length; i++) {
                Console.Write($"{array[i]} ");
            }
            //remaining flowers to plant count
            Console.WriteLine($"\nFlowers left to plant: {n}");

            //ternary to print false if not all flowers planted, true if they are
            Console.WriteLine("-------------------------");
            Console.WriteLine(allPlantsGone ? "True: All Flowers Planted\n"
                                            : "False: Not enough space for Flowers\n");
        }

        static void UserFlowerBeds() {
            //prompt user for flower bed and how many flowers to plant
            Console.WriteLine("Using 1 for filled and 0 for empty ie --> 1 0 0 0 1");
            Console.Write("What does your flower bed look like: ");
            string flowerSpots = Console.ReadLine();
            Console.Write("How many flowers do you wish to plant: ");
            int flowersToPlant = int.Parse(Console.ReadLine());

            //build flower bed with layout given by user
            int[] userFlowerBed = flowerSpots.Split(' ').Select(int.Parse).ToArray();

            //initialize flowersToPlant to not planted
            bool allPlantsGone = false;

            //visual demonstration of flower bed with flower count
            for (int i = 0; i < userFlowerBed.Length; i++) {
                Console.Write($"{userFlowerBed[i]} ");
            }
            Console.WriteLine($"\nFlower Count: {flowersToPlant}");

            //iterate through user array starting index 1 and ending before last index
            for (int i = 0; i < 1; i++) {
                if (userFlowerBed[i] == 0 && userFlowerBed[i + 1] == 0) {
                    userFlowerBed[i] = 1; //plant a flower
                    flowersToPlant--; //decrease the flower count
                }
            }
            for (int i = 1; i < userFlowerBed.Length - 1; i++) {
                if (userFlowerBed[i - 1] == 0 && userFlowerBed[i] == 0 && userFlowerBed[i + 1] == 0) {
                    userFlowerBed[i] = 1; //plant flower
                    flowersToPlant--; //decrease flower count
                }
            }

            //visual demonstration of flower bed after flowers planted
            Console.WriteLine("-------------------------");
            for (int i = 0; i < userFlowerBed.Length; i++) {
                Console.Write($"{userFlowerBed[i]} ");
            }
            //remaining flowers to plant count
            Console.WriteLine($"\nFlowers left to plant: {flowersToPlant}");

            //check if all flowers planted
            if (flowersToPlant <= 0) {
                allPlantsGone = true;
            }

            //ternary to print false if not all flowers are planted, true if they are
            Console.WriteLine("-------------------------");
            Console.WriteLine(allPlantsGone ? "True: All Flowers Planted\n"
                                            : "False: Not enough space for Flowers\n");
        }
    }
}
