using System;
using System.Linq;
using static System.Console;

public class Mains {
  public static void Main()
  {
R6S myOperator = new R6S();
/* creates a new object, format is 
CLASS NAME - VAR NAME = NEW (CLASS NAME) ();
*/
myOperator.operators = ReadLine();
WriteLine (myOperator);
R6S myName = new R6S();
WriteLine(myName.player);
R6S myGun = new R6S();
WriteLine(myGun.guns);
R6S myLevel = new R6S();
WriteLine(myLevel.level);

R6S camos = new R6S();
camos.operators = "All colors";
camos.player = "Diamond";
camos.guns = "All guns";

R6S operators = new R6S();
operators.operators = "IQ, Hibana, Echo";
WriteLine("What operator will you select?");
operators.operators = ReadLine();
WriteLine("You have selcted: " + operators.operators);

}

}
// end main class
class R6S
{
  public String operators;
  // operator name - field
  public string player;
  // player username
  public string guns;
  // gun used
  public int level;
  // players current level


  public void Ubisoft()
  {
    // Method
    WriteLine("Welcome to R6S!, enter your username: ");
    player = ReadLine();
    WriteLine("Hi there player: " + player);

  }
}

/*class Second
{
  private static void Calc()
  {
// methods to round and find mac values of digits (Input)
WriteLine("Please enter a value for a and b: ");
double a = double.Parse(ReadLine());
double b = double.Parse(ReadLine());
WriteLine("A B MAX: " + Math.Round(Math.Max(a,b)));

// methods for upper/lowercase and .Length
string txt = "Hello world";
WriteLine (txt.ToUpper());
WriteLine(txt.ToLower());

// concatentate
string firstName = "John ";
string lastName = "Doe";
string fullName = firstName + lastName;
WriteLine("Ur name is: " + fullName);

// string interpolation
string firstName = "Jose ";
string lastName = "Orozco";
string name = $"Name is: {firstName} {lastName}";
WriteLine(name);

// accessing strings using IndexOf, Substring
string myName = "Hello";
WriteLine(myName[2]); // l
WriteLine(myName.IndexOf("l")); // 2
string name = "Jose Orozco";
int charPos = name.IndexOf("O");
// Orozco
string lastName = name.Substring(charPos);
WriteLine(lastName);

// shorhand operators for if and else chains
/* instead of if else chain we can use shorthand operators 
double time = 9.00;
if (time > 12)
{
  WriteLine("Good afternoon");
}
else if (time == 9.00)
{
  WriteLine("Good morning");
}
else
{
  WriteLine("Good day!");
}
// shortahand ex
double time2 = 9.00;
string result = (time > 12) ? "Good afternoon" : "Good morning";
WriteLine(result);

// Switch statments and break keyword

int color = 4;
switch(color)
{
  case 1:
  WriteLine("Blue");
  break;
  case 2:
  WriteLine("Red");
 break;
  case 3:
  WriteLine("Black");
  break;
  default: 
  WriteLine("NAN");
  break;
  // prints black
}
//while loop
int i = 0;
while (i < 5)
{
  WriteLine(i);
  i++;
}
// do while loop 
int j = 0;
do 
{
  WriteLine(j);
  j++;
}
while(j < 5);

// for loop
for (int i = 0; i < 5; i++)
{
  WriteLine(i);
}
// for each loop is only for arrays
string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
foreach(string j in cars)
{
  WriteLine(j);
}

// break and continue in loops
for (int i = 0; i < 10; i++)
{
  if (i == 4)
  {
    
  continue;
  // skips 4
  // break; ends at 4
  }
  WriteLine(i);
}

// break within while loop
int i = 0;
while(i < 10)
{
  WriteLine(i);
  i++;
  if(i == 4)
  {
    break;
  }
}
// continue within while loop
int j = 0;
while(j < 10)
{
  if (j == 4)
  {
    j++;
    continue;
  }

  WriteLine(j);
  j++;
}
// break statements and loops game on github not on this reference sheet

// arrays
    // declaring array
    string[] cars = {"Ford", "Chevy ", "Honda"};
    string[] colors = {"Blue", "Yellow", "Red"};

    WriteLine(colors);
    WriteLine(colors[0]);
    WriteLine(colors.Length);
  
    // accessing array elements
    WriteLine(cars[0]);
    //Ouputs Ford

    // change an arrays value
    cars[0] = "Lambo";
    WriteLine(cars[0]);
    // Length of an array
    WriteLine(cars[0].Length);
    // length of car at 0
    // Loop through an array

    for (int i = 0; i < cars.Length; i ++)
    {
      WriteLine(cars[i]);
    }
    // using foreach 
    foreach (string j in cars)
    {
      WriteLine(j);
    }

    // sorting arrays
    Array.Sort(cars);
    foreach(string k in cars)
    {
      WriteLine(k);
      // alphabetically
    }
    int[] numbers = {2, 1, 10};
    Array.Sort(numbers);
    foreach(int i in numbers)
    {
      WriteLine(i);
    }
    // methods aka reusable code
    /* this is how to pass 
  paramaters () from a function aka method to Main() you call the method name in Main and input something within the paramaters. When a paramater is passed to a method they are called arguements, so name is a parameter but Orozco is a argument
public static void Method(string fname, int age)
{
WriteLine(fname + "is " + age);
}
static int Calc(int x)
{
  return 5 + x;
}
public static int Add (int y, int z)
{
  return y + z;
}
public static void christmas(string child1 = "Johnny", string child2 = "Jose", string child3 = "nan")
{
  WriteLine(child1);
}
public static void Main()
{
Method("Jose ", 18);
Method("Johnny ", 19);
WriteLine(Calc(2));
int total = Add(10,0);
// so that total is equal to a variable
WriteLine(total);
// named arguments only the ones you want to use:
christmas("child1");
}
}
}
Method Overloading multiple methods aka functions having the same name but different paramters, ie, int a (int x), and int a (bool yes);


// overloading methods
public static int PlusMethod(int x, int y)
{
return x + y;
}
public static double PlusMethod(double x, double y)
{
  return x + y;
}
public static void Main()
{
int myNum1 = PlusMethod(8,0);
double myNum2 = PlusMethod(2.2, 2.3);
WriteLine(myNum1);
WriteLine(myNum2);
}
}
*/
/*
ADVANCED C# - OOP 
class is a blueprint for objects
classes - fruit
objects from class: apples, bannanas, oranges
car is an object
car attributes: color, weight - visual
methods: drive, break - functional

// variable within a class is a field or attribite so color is a field
class Mains{
public static void Main()
{
  Car myObj = new Car();
  WriteLine(myObj.color);
  Game myGame = new Game();
  WriteLine(myGame.videoGame);
  Game.function("");
}
}
class Car
{
public string color = "red";
}
class Game
{
  // public keyword is an access modifier, to allow access of the field of Car
  public string videoGame = "COD";
  public static void function(string name)
  {
    WriteLine("What is your name?");
    name = ReadLine();
    WriteLine("Hello, " + name);
  }
}
// OOP Classes and Objects, Fields and Methods, using classes

// variable within a class is a field or attribite so color is a field
public class Mains {
  public static void Main()
  {
      // new object from fruit class 
      fruit Apple = new fruit();
      Apple.name =  "Apple";
      Apple.color = "Red";
      Apple.price = 1;
      // new object from fruit class
      fruit Pear = new fruit();
      Pear.name = "Pear";
      Pear.color = "Green";
      Pear.price = 2;
      WriteLine("Pear price is: " + Pear.price);
      // new object using method 
      fruit fruitVendor = new fruit();
      fruit.vendor();
      // static members can be accessed w/out creating an object, public can only be accessed by objects

      // it is reccomended to use different classes, one for the methods and functionality, and one for the actual execution that contains the Main();
      }
}

class fruit
{
  public string name;
  public string color;
  public int price;
  public static void vendor()
  {
    WriteLine("Come and get your fruits!");
  }
}


*/