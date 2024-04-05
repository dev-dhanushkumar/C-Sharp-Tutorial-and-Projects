using System;



// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Step1: Declaration 
//Step2: Initialization

int x; //declaration
x = 10; //initialization

int y = 123; //declaration + initialization

int result = x + y;

Console.WriteLine(x);
Console.WriteLine(y);
Console.WriteLine(result);

int age = 19; //whhole integer
Console.WriteLine("My age is: "+ age);

double height = 300.5; //decimal number
Console.WriteLine("my height is: " + height);

bool alive = true; //boolean value
Console.WriteLine("Are you Alive? " + alive);

char symbol = '@'; //character data type
Console.WriteLine("Your symbol is :" + symbol);

string name = "Bro";
Console.WriteLine("Hello " + name);

String username = symbol + name;
Console.WriteLine("Your username is: " + username);

//constant = immutable values which are know at compile time and 
// do not change for the life of the program

const double pi = 3.14; //constant 

Console.WriteLine("Pi value: " + pi);

Console.ReadKey();