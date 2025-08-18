using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6._2._1 {
    internal class MTGNumbers {
        public int MTGStack;
        public MTGNumbers next;

        public MTGNumbers(int stack) {
            MTGStack = stack;
            next = null;
        }
    }

    class TheStack {
        private MTGNumbers head;
        private MTGNumbers tail;
        private int size;

        public int Size {
            get { return size; }
        }

        public bool IsEmpty() {
            return this.size == 0;
        }

        public TheStack() {
            head = null;
            size = 0;
            Push(10);
            Push(50);
            Push(70);
        }

        public void Push(int value) {
            MTGNumbers newNode = new MTGNumbers(value);
            newNode.next = head;
            head = newNode;
            size++;
        }

        public int Pop() {
            int value = head.MTGStack;
            if (IsEmpty()) {
                Console.WriteLine("Stack is empty.");
            }
            else {
                head = head.next;
                size++;
            }
            return value;
        }

        public void Display() {
            MTGNumbers temp = head;
            Console.WriteLine("-- Current Stack --");
            while (temp != null) {
                Console.WriteLine($" [ {temp.MTGStack} ]");
                temp = temp.next;
            }
        }
    }
}
