using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_7._1._1 {
    /*
    You are a student who has recently taken an exam with your classmates. However,
    the professor has not yet provided the students with a sorted list of exam scores.
    To make things easier, you write a program to sort exam scores in ascending order
    using the selection sort algorithm. This way, you can obtain the sorted list of
    scores and see how you performed compared to your classmates. Also, you choose
    selection sort since that is an easy way of implementation. 
    */
    public enum StudentGrade {
        A = 4,
        B = 3,
        C = 2,
        D = 1,
        F = 0
    }
    public class Student {
        public string StudentName { get; set; }
        public StudentGrade Grade {get; set;}

        public static List<Student> GetSampleStudents() {
            return new List<Student> {
                new Student {
                    StudentName = "Brock", Grade = StudentGrade.B
                },
                new Student {
                    StudentName = "James", Grade = StudentGrade.C
                },
                new Student {
                    StudentName = "Jesse", Grade = StudentGrade.C
                },
                new Student {
                    StudentName = "Lance", Grade = StudentGrade.A
                },
                new Student {
                    StudentName = "Joy", Grade = StudentGrade.A
                },
                new Student {
                    StudentName = "Lorelei", Grade = StudentGrade.B
                },
                new Student {
                    StudentName = "Bruno", Grade = StudentGrade.D
                },
                new Student {
                    StudentName = "Jasmine", Grade = StudentGrade.A
                },
                new Student {
                    StudentName = "Claire", Grade = StudentGrade.B
                },
                new Student {
                    StudentName = "Giovanni", Grade = StudentGrade.F
                },
            };
        }
        
    }
}
