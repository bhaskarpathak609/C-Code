// See https://aka.ms/new-console-template for more information
using System.Diagnostics;
using System.Formats.Asn1;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;

//Print the line 
Console.WriteLine("Hello, Bhaskar");

// Taking input values from the variable 
string firstfriend = "        Bhaskar            ";
string secondfriend = "Honey";
Console.WriteLine($"My friends are {firstfriend.Trim()} {secondfriend}"); // single shot trim


// Triming from the end
string trimvalues = firstfriend.TrimEnd();
Console.WriteLine($"my friends are [{trimvalues}]");

// Triming from start
string trimeend =   firstfriend.TrimStart();
Console.WriteLine($"My friends are [{trimeend}]");

// Trime command for all the word
string trime = firstfriend.Trim();
Console.WriteLine($"My friend is [{trime}]");

//Replace the string
string sayHello = "Hello World!!!";
Console.WriteLine(sayHello);
string saynewhello = sayHello.Replace("Hello", "greeting");
Console.WriteLine(saynewhello);

// toUpper ToLower
Console.WriteLine(sayHello.ToUpper());
Console.WriteLine(sayHello.ToLower());  

//Search string
string songlyrics = "You say goodbye, and I say hello";

Console.WriteLine(songlyrics.Contains("goodbye"));
Console.WriteLine(songlyrics.StartsWith("goodbye"));
Console.WriteLine(songlyrics.EndsWith("hello"));

int a = 18;
int b = 6;
int c = a+b;
int d = a-b;
int e = a*b;
int f = a/b;
Console.WriteLine(c);
Console.WriteLine(d);
Console.WriteLine(e);
Console.WriteLine(f);

int x = 21000000;
int y = 21000000;
long z = checked(a + b);
Console.WriteLine(z);

double l = 4.2; // Natural type
float m = 4.2F;
double n = l+m;
Console.WriteLine(n);


decimal j = 42.1M; // Explicit type
decimal k = 32.8M;
decimal g = j+k;
Console.WriteLine($"The answer is {g}");

// area of a circle 
double radius = 2.5;
double area = Math.PI * radius * radius;
Console.WriteLine(area);


////////////Branch and loops///////////
///
