
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography.X509Certificates;

class LINQLearner //LINQ= Language integrated query which is a declarative 
{
    void Learn() //method
    {
        int[] numbers = [3, 4, 5, 67, 12, 34, 56,78, 89, 98, 123];
        List<string> names = ["Seema", "Rita", "Iliya", "Sapana", "Jenu", "Smriti"];
        
        var S1 = new Student("Iliya", 4, new DateTime(2001, 07, 03));
        var S2 = new Student("Jenu",  5, new DateTime(2000, 08, 05));
        var S3 = new Student("Bipana", 6, new DateTime(2003, 09, 11));
        var S4 = new Student("Smrtit", 7, new DateTime(2002, 10, 06));
        var S5 = new Student("Salina", 8, new DateTime(2004, 12, 07));
        
        List<Student> students = [S1, S2, S3, S4, S5];

        //Get odd numbers form the 'numbers' array
        var oddNumbers= numbers.Where(numbers => numbers%2 == 1 ); //lambda expression for the logic
        
        //Enumeration is to able to list out the numbers

        // Get squares of all items in "numbers"
        var squares = numbers.Select( x=> x * x);

        //Get squares of even numbers only
        //Method Syntax
        var SquareOfEven = numbers.Where(enumbers => enumbers%2 == 1).Select(x => x * x);

        //Query Syntax
        SquareOfEven = from x in numbers
            where x % 2 == 0
            select x*x;

        //Get  all name initials 
        var initials = names.Select(name => name[0]); //{'S', 'R', 'I', 'S', 'J', 'S'}

        // Order name in ascending order
        var namesOrderes = names.OrderBy( x=> x);

        //Find the name of the student starting with  B
        var Bstudent = students.Where(student => student.name.ToLower().StartsWith('b'));

        //Group students by birth month
        var BirthMonthGroup = students.GroupBy(student => student.Dob.Month);

        //Get youngest student
        var youngestByAge = students.OrderByDescending(x => x.Dob).First();
       youngestByAge = students.MaxBy(x => x.Dob);
        
                }
}