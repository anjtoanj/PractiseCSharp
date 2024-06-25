// Inheritance of objects

// Create a C# program that prompts the user for three names of people and stores them in an array of Person-type objects. 
// There will be two people of the Student type and one person of the Teacher type.

// To do this, create a Person class that has a Name property of type string, a constructor that receives the name as a parameter 
// and overrides the ToString() method.

// Then create two more classes that inherit from the Person class, they will be called Student and Teacher. 
// The Student class has a Study method that writes by console that the student is studying. 
// The Teacher class will have an Explain method that writes to the console that the teacher is explaining. 
// Remember to also create two constructors on the child classes that call the parent constructor of the Person class.

// End the program by reading the people (the teacher and the students) and execute the Explain and Study methods.

// Input
// Juan
// Sara
// Carlos

// Output
// Explain
// Study
// Study

using System;
public class InhertianceObjects
{
     public static void Main(string[] args)
     { 
        int total = 3 ;
        Person[] person = new Person[total];
         for (int i=0;i<total;i++){
            if(i==0){
                person[i] =new Teacher(Console.ReadLine());
            }
            else{
                person[i] = new Student(Console.ReadLine());
            }
         }

         for(int i =0;i<total;i++){
            if(i==0){
                ((Teacher)person[i]).explain();
            }
            else{
                ((Student)person[i]).study();
            }
         }


     }
}
class Person 
{
    public string Name{get;set;}
    public Person (string name)
    {
        Name = name;
    }
    public override string ToString()
    {
        return "Hello! My name is :" + Name;
    }      
 
}
class Student : Person
{
    public Student(string name): base(name)
    {
        Name = name;
    }
    public void study()
    {
            Console.WriteLine("the student is studying");
    }
}

class Teacher : Person
{
    public Teacher(string name): base(name)
    {
        Name = name;
    }
    public void explain(){
        Console.WriteLine("the teacher is explaining");
    }
}