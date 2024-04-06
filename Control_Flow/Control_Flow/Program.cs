// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, to Control flow statement!");


//If else statement
int age = 12;
if (age > 18)
{
    Console.WriteLine("You are eligible for vote!");
}else
{
    Console.WriteLine("Ooops! You are not eligible for Vote!");
}

//if, else if, else statement
int a = 10, b = 20, c = 30;
if(a > b)
{
    Console.WriteLine("A is Biggest value");
}else if (a>c)
{
    Console.WriteLine("B is Biggest value");
} else
{
    Console.WriteLine("C is Biggest value");
}


//Switch Statement
int ch;
Console.WriteLine("Enter your Choice!");
ch = Convert.ToInt32( Console.ReadLine());
switch (ch)
{
    case 1: Console.WriteLine("Dhanush"); break;
    case 2: Console.WriteLine("Kumar"); break ;
    default: Console.WriteLine("Please! Enter the correct choice!"); break;
}

//for loop statement
for (int i = 0; i< 10; i++)
{
    if (i == 5) continue;
    Console.WriteLine("i value is:" + i);
    
}

//sum of n natural numbers
int n = 5, sum = 0;
for (int i =0; i<= n; i++)
{
    sum += i;
}
Console.WriteLine("Sum of Natural Numbers:" + sum);

//While Loop 
int j = 0;
while(j < 10)
{
    Console.WriteLine("# While loop time:" + j);
    j++;
}

//inner and outer loop
void NestaedLoop()
{
    int outerloop = 0, innerloop = 0;
    for(int i =0; i<5; i++)
    {
        outerloop++;
        for( int j =1; j < 5; j++)
        {
            innerloop++;
        }
    }
    Console.WriteLine("Outer Loop runs {0} times", outerloop);
    Console.WriteLine("Inner Loop runs {0} times",  innerloop);
}

NestaedLoop();