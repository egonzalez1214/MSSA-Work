namespace Assignment_7._1._1 {
    internal class Program {
        /* Assignment Details *
        You are a student who has recently taken an exam with your classmates. However,
        the professor has not yet provided the students with a sorted list of exam scores.
        To make things easier, you write a program to sort exam scores in ascending order
        using the selection sort algorithm. This way, you can obtain the sorted list of
        scores and see how you performed compared to your classmates. Also, you choose
        selection sort since that is an easy way of implementation. 
        */
        static void Main(string[] args) {
            Console.WriteLine("Hello, World!\n");
            //Generate List from Student class
            List<Student> students = Student.GetSampleStudents();
            //Run SelectSort Program
            SelectSort(students);
        }

        static void SelectSort(List<Student> students) {
            Student temp; // can't be int temp... needs to be variable of Student...
            for (int i = 0; i < students.Count - 1; i++) { //lists use .Count, not .Length...
                int minPosition = i;
                for (int j = i + 1; j < students.Count; j++) { //j starts at i + 1...
                    //call with .Grade, not Student.Grade...
                    if (students[j].Grade < students[minPosition].Grade) {
                        minPosition = j;
                    }
                }
                //same as shown in class...
                if (minPosition != i) {
                    temp = students[i];
                    students[i] = students[minPosition];
                    students[minPosition] = temp;
                }
            }
            foreach (Student s in students) { //class object in list...
                Console.WriteLine($"{s.StudentName}: {s.Grade}");
            }
        }
        /*
        This took about an hour... built the class fairly easily, had to look up how
        to make enum constructor, but was very close. Had trouble calling my class to
        print... and I messed up a few things, but overall not too difficult and only
        a little time consuming...
        */
    }
}