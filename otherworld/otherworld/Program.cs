// See https://aka.ms/new-console-template for more information

using otherworld;

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

// next classssssssssssssss
// inputing data in class
Whhhhhaaaaaa firstMovie = new Whhhhhaaaaaa();
firstMovie.MovieTitle = "The Flash";
firstMovie.MovieReleaseYear = 2023;
firstMovie.MovieReleaseStatus = true;

Whhhhhaaaaaa secondMovie = new Whhhhhaaaaaa();
secondMovie.MovieTitle = "Elemental";
secondMovie.MovieReleaseYear = 2023;
secondMovie.MovieReleaseStatus = false;

Whhhhhaaaaaa thirdMovie = new Whhhhhaaaaaa();
thirdMovie.MovieTitle = "Doki Doki Literature Club";
thirdMovie.MovieReleaseYear = 2019;
thirdMovie.MovieReleaseStatus = true;
// Creating the outputted statement
string firstMovieStuff = $"The name of this movie is: " +
    $"{firstMovie.MovieTitle} and its being released in " +
    $"{firstMovie.MovieReleaseYear} and its status is currently {firstMovie.MovieReleaseStatus}.";
string secondMovieStuff = $"The name of this movie is: " +
    $"{secondMovie.MovieTitle} and its being released in " +
    $"{secondMovie.MovieReleaseYear} and its status is currently {secondMovie.MovieReleaseStatus}.";
string thirdMovieStuff = $"The name of this movie is: " +
    $"{thirdMovie.MovieTitle} and its being released in " +
    $"{thirdMovie.MovieReleaseYear} and its status is currently {thirdMovie.MovieReleaseStatus}.";



// outputing the statements to the user
Console.WriteLine(firstMovieStuff);
Console.WriteLine(secondMovieStuff);
Console.WriteLine(thirdMovieStuff);

// games classes
Games firstGame = new Games();
firstGame.GameTitle = "Team Fortress 2";
firstGame.GameReleaseDate = 2007;
firstGame.GameType = "fps";
firstGame.GameDevice = "PC";

Games secondGame = new Games();
secondGame.GameTitle = "Call of Duty Black ops 1";
secondGame.GameReleaseDate = 2010;
secondGame.GameType = "fps";
secondGame.GameDevice = "PC/Xbox/Playstation";

Games thirdGame = new Games();
thirdGame.GameTitle = "Valorant";
thirdGame.GameReleaseDate = 2020;
thirdGame.GameType = "fps";
thirdGame.GameDevice = "PC";

//creating the outputed statement
string firstGameStuff = $"One of the best games was {firstGame.GameTitle} " +
    $"it was released in {firstGame.GameReleaseDate} and was revolutionary. " +
    $"It was a game which was accesiable to {firstGame.GameDevice} and was a " +
    $"{firstGame.GameType} which had a massive player base.";
string SecondGameStuff = $"One of the best games was {secondGame.GameTitle} " +
    $"it was released in {secondGame.GameReleaseDate} and was revolutionary. " +
    $"It was a game which was accesiable to {secondGame.GameDevice} and was a " +
    $"{secondGame.GameType} which had a massive player base.";
string thirdGameStuff = $"One of the best games was {thirdGame.GameTitle} " +
    $"it was released in {thirdGame.GameReleaseDate} and was revolutionary. " +
    $"It was a game which was accesiable to {thirdGame.GameDevice} and was a " +
    $"{thirdGame.GameType} which had a massive player base.";

// outputting the statement to the users
Console.WriteLine(firstGameStuff);
Console.WriteLine(SecondGameStuff);
Console.WriteLine(thirdGameStuff);