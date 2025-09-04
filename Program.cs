// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int age = 35;
double age2 = 25.5;
float position = 35.5f;
Console.WriteLine("Number" + 5 + 6);
Console.WriteLine(5 + 6 + "Number");

string name = "Alejandro";

Console.WriteLine("My name is " + name + " and I'm " + age + " years old.");
Console.WriteLine($"My name is {name} and I'm {age} years old.");

char character = 'a';
Console.WriteLine("My name is \"Alejandro Foucault\"");

bool isPlayer = true;
bool isEnemy = false;

var myVariable = 10.2;

//long ageUniverse = 15;
//int ageUniverseInt = ageUniverse;

int ageUniverseInt = 15;
long ageUniverse = ageUniverseInt;

int health = Convert.ToInt32("56");
int healthMax = 10;
Console.WriteLine((float)health / healthMax);