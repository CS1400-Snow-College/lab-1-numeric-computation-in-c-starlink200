// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// operands include == + - / % *
int a = 18;
int b = 6;
// "/" represents division, when using integers it will always return a whole number
int c = a / b;
Console.WriteLine(c);
// "%" represents modulus which returns the remainder when a int is divided
c = a % b;
Console.WriteLine(c);
// == is used to compare to integers or numerical data types (floats compared to floats etc...)
if(a == b){
    Console.WriteLine("a = b");
}
// order of operations is applied to mathmatical problems
c = a + b * c;
Console.WriteLine(c);
c = (a + b) * c;
Console.WriteLine(c);

int max = int.MaxValue;
int min = int.MinValue;
Console.WriteLine($"The range of integers is {min} to {max}");
//overflow is when the max value is exceeded
//the number wraps so once you hit the max value it will start at the other end and continue
int what = max + 100;
Console.WriteLine($"An Example of overflow... {what}");
//another numerical data type is the double
double doubleMax = double.MaxValue;
double doubleMin = double.MinValue;
Console.WriteLine($"the range of a double is {doubleMin} to {doubleMax}");

//another numbercal data type is the decimal which allows for more precise decimal points
double one = 1;
double third = 3;
Console.WriteLine(one/third);
decimal uno = 1;
decimal trace = 3;
//the double goes to fewer decimal points than the decimal
Console.WriteLine(uno/trace);
Console.WriteLine();
Console.WriteLine("Choose a radius of a cicle");
string radius = Console.ReadLine();
double r = Convert.ToDouble(radius);
double circleArea = (r*r) * Math.PI;
Console.WriteLine($"The area of a circle with radius {r} is {circleArea}");

//loops and conditional statements are the same format as Java
if (circleArea >= 15){
    Console.WriteLine($"The area of the circle {circleArea} is greater than 15");
}
else{
    Console.WriteLine($"The area of the circle {circleArea} is less than 15");
}
int counter = 6;
//++ or -- increments the value by one either up or down respectively
//do while will run the code of the while loop once and then if the the while statement
//is true then it will enter the while loop, if not then it won't