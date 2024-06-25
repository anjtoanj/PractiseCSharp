using System;
 
// Create a C# program that prompts the user for three names of people and stores them in an array of Person-type objects. 
// To do this, first create a Person class that has a Name property of type string, a constructor that receives the name as a parameter, 
// a destructor that assigns the name to empty and overwrites the ToString () method.
// End the program by reading the people and executing the ToString () method on screen.


public class ConstructorsAndDestructors
{ 
  public static void Main(string[] args){

  }

  public class Person
  {
    public string Name {get; set;}
    public Person (string name)
    {
        Name = name;
    }
    public override string ToString()
    {
        return "Hello ! My name is  " +Name;
    }
    ~Person(){
        Name = string.Empty;
    }

  }

}