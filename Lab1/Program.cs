Console.WriteLine("Hello, World!");
Console.WriteLine("Hey Bre! Welcome to IT-1050");
//Bre Mireles Title:[IT-1050- Lab1]
//Step 2
Console.WriteLine("Bre Mireles - Course Title: IT-1050");
//Step3
int myAge = 24;
string favProgLang = "Python";
double progPrior = 10;
bool progExper = true;
Console.WriteLine("I am " + myAge + " years old," + " my favorite programming language is: " + favProgLang + "." + " The number of programs I've written before this lab is at least " + progPrior + "," + " and it is " + progExper + " that I have programming experience.");
//Step 4
const string mySchool = "School name: Tri-C";
Console.WriteLine(mySchool);
//Step 5 
double randDeci = 9.78;
bool randBool = true;

Console.WriteLine(Convert.ToString("Double: " + randDeci));
Console.WriteLine(Convert.ToString("Boolean to string: " + randBool));
//Step6
Console.WriteLine("Enter name: ");
string userName = Console.ReadLine();

Console.WriteLine("Enter age please: ");
string ageInput = Console.ReadLine();
int userAge = Convert.ToInt32(ageInput);

Console.WriteLine("Hello " + userName + "!" + " You are " + userAge + " years old. ");
//Step 7 - Arithmetic Operators 
int num1 = 50;
int num2 = 40;
Console.WriteLine("50+10= " + (num1 + 10));
Console.WriteLine("40+10=" + (num2 + 10));
Console.WriteLine("50-2= " + (num1 - 2));
Console.WriteLine("40-2= " + (num2 - 2));
Console.WriteLine("50*3= " + (num1 * 3));
Console.WriteLine("40*3= " + (num2 * 3));
Console.WriteLine("50/2= " + (num1 / 2));
Console.WriteLine("40/2= " + (num2 / 2));
Console.WriteLine("Remainder of 50/2= " + (num1 % 2));
Console.WriteLine("Remainder of 40/2= " + (num2 % 2));
//Step 8 - Floadting Point Precision
float randFloat = 1.123456789F;
double randDouble = 1.123456789D;
Console.WriteLine($"Float:  {randFloat} Double : {randDouble}");
//Step 9 - Increment and Decremend 
int randVal = 10;
Console.WriteLine(randVal++);
Console.WriteLine(randVal--);
