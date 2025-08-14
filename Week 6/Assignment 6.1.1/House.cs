using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6._1._1 {

    public class House {
        public int HouseNumber;
        public string HouseAddress;
        public string HouseColor;
        public House next;

        public House(int number, string address, string color) {
            HouseNumber = number;
            HouseAddress = address;
            HouseColor = color;
            next = null;
        }
    }
    
    class HouseList {
        private House head;
        private House tail;
        private int size;

        public int Size {
            get { return size; }
        }

        public HouseList() {
            head = null;
            tail = null;
            size = 0;
            AddFirst(1001, "123 Main St", "Blue");
            AddFirst(1002, "456 Oak Ave", "Red");
            AddFirst(1003, "789 Pine Way", "Green");
            AddFirst(1004, "321 Lexi Ave", "Yellow");
            AddFirst(1005, "654 Charter St", "Blue");
            AddFirst(1006, "987 Vince Way", "Green");
        }

        public bool IsEmpty() {
            return this.size == 0;
        }

        public void AddFirst(int number, string address, string color) {
            House newNode = new House(number, address, color);
            if (IsEmpty()) {
                head = newNode;
                tail = newNode;
            }
            else {
                newNode.next = head;
                head = newNode;
            }
            size++;
        }

        public House SearchByHouseNumber(int number) {
            House temp = head;
            while (temp!= null) {
                if (temp.HouseNumber == number) {
                    Console.Write($"Number: {temp.HouseNumber} | " +
                                  $" Address: {temp.HouseAddress} | " +
                                  $" Color: {temp.HouseColor} |");
                    return temp;
                }
                temp = temp.next;
            }
            Console.WriteLine("House not found.");
            return null;
        }

        public void Display() {
            House temp = head;
            if (IsEmpty()) {
                Console.WriteLine("List is empty.");
            }
            else {
                while (temp != null) {
                    Console.Write($"Number: {temp.HouseNumber} | " +
                                  $" Address: {temp.HouseAddress} | " +
                                  $" Color: {temp.HouseColor} |");
                    if (temp.next != null) {
                        Console.WriteLine("\n ---> ");
                    }
                    else {
                        Console.WriteLine();
                    }
                    temp = temp.next;
                }
            }
        }
    }
}
