// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

Console.WriteLine("i am Lewis");

string myName = "Lewis";

string myMotorbike = "Honda";

string MotorbikeEngine = "250";

Console.WriteLine("I own a " + MotorbikeEngine + " " + myMotorbike + ".");

// function definition
void FunctionTypeOne()
{
    string someString = "the flash movoe os not that good";
    Console.WriteLine(someString);
}

// function call
FunctionTypeOne();

//dunction fefinition
void FunctionTypeTwo(int numberofmovies)
{
    string ouputSentence = $"I have watched {numberofmovies} movies this year";
    Console.WriteLine(ouputSentence);
}

int tobeSentToFunctionMovieCount = 200;

FunctionTypeTwo(tobeSentToFunctionMovieCount);

//same as Type two but with more than one parameter
void FunctionTypeTwoPartB(int one, string two, bool three)
{
    string someOutput = $"The values are {one}, {two}, {three}";
    Console.WriteLine(someOutput);
}

int one = 1;
string two = "two";
bool three = true;

FunctionTypeTwoPartB(one, two, three);

//function definition

//function that will add two numbers
int FunctionThatAddsTwoNumbers(int numberOne, int numberTwo)
{
    int sum = numberOne + numberTwo;
    return sum;
}

int doubleooseven = 7;
int randomagent = 50;

//function call

int result = FunctionThatAddsTwoNumbers(doubleooseven, randomagent);

string outputofAgents = $"The sum of {doubleooseven} and {randomagent} is {result}";
Console.WriteLine(outputofAgents);

int FunctionThatReturnsRandomNumber()
{
    Random random= new Random();
    int randomNumber = random.Next(1, 100);
    return randomNumber;
}

int FunctionThatReturnsRandomNumber2(int lowerbound, int upperbound)
{
    Random random = new Random();
    int randomNumber = random.Next(lowerbound, upperbound);
    return randomNumber;
}

//function call
//I simply want a random number, between 1 and 100

int randomnumber = FunctionThatReturnsRandomNumber();
string somerandomsentence = $"The random number is {randomnumber} between 1 and 100, no parameters are sent";

Console.WriteLine(somerandomsentence);

//I want a random number between 500 and 800
int lowerboundvalue = 500;
int upperboundvalue = 800;
int randomnumber2 = FunctionThatReturnsRandomNumber2(500, 800);
string somerandomsentence2 = $"The random number is {randomnumber2} between {lowerboundvalue} anbd {upperboundvalue}";

Console.WriteLine(somerandomsentence2);

