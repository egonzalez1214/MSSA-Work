using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6._3._1 {
    internal class Customer {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        
        public Customer next;

        public Customer(int id, string name) {
            CustomerID = id;
            CustomerName = name;
            next = null;
        }
    }

    class CustomerQueue {
        private Customer head;
        private Customer tail;
        private int size;
        private int nextID; // <-------- Keeps track of available ID
        
        public CustomerQueue() {
            head = null;
            tail = null;
            size = 0;
            nextID = 1; // <------------ Starts ID at 1
            Enqueue("Jesse");
            Enqueue("James");
            Enqueue("Lance");
        }
        
        public int Size {
            get { return size; }
        }

        public bool IsEmpty() {
            return this.size == 0;
        }

        public void Enqueue(string name) {
            Customer newNode = new Customer(nextID, name);
            nextID++; // <--------------- Increments ID for next customer
            if (IsEmpty()) {
                head = newNode;
                tail = newNode;
            }
            else {
                tail.next = newNode;
                tail = newNode;
            }
            size++;
        }

        public Customer Dequeue() {
            if (IsEmpty()) {
                Console.WriteLine("Queue is empty.");
                return null;
            }
            Customer dequeued = head;
            head = head.next;
            if (head == null) {
                tail = null;
            }
            size--;
            ResetIDs(); // <-------------- Reset IDs whenever dequeue happens
            return dequeued;
        }

        private void ResetIDs() {
            int id = 1;
            Customer temp = head;
            while (temp != null) {
                temp.CustomerID = id;
                id++;
                temp = temp.next;
            }
            nextID = id;
        }

        public void Display() {
            Customer temp = head;
            if (IsEmpty()) {
                Console.WriteLine("Queue is empty.");
            }
            else {
                while (temp != null) {
                    Console.WriteLine($"Customer {temp.CustomerID}: {temp.CustomerName}");
                    temp = temp.next;
                }
            }
        }
    }
}
