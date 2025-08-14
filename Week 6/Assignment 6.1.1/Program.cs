namespace Assignment_6._1._1 {

    internal class Program {

        static void Main(string[] args) {
            Console.WriteLine("Hello, World!\n");

            HouseList myHouses = new HouseList();
            myHouses.Display();
            Console.WriteLine("----------------------\n");
            Console.WriteLine("Type in the house number you want to search for: ");
            int houseNumber = int.Parse(Console.ReadLine());
            myHouses.SearchByHouseNumber(houseNumber);
            Console.WriteLine();
        }
    }
}
