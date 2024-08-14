// See https://aka.ms/new-console-template for more information
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Diagnostics;
using System.Formats.Asn1;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
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
string trimeend = firstfriend.TrimStart();
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
int c = a + b;
int d = a - b;
int e = a * b;
int f = a / b;
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
double n = l + m;
Console.WriteLine(n);


decimal j = 42.1M; // Explicit type
decimal k = 32.8M;
decimal g = j + k;
Console.WriteLine($"The answer is {g}");

// area of a circle 
double radius = 2.5;
double area = Math.PI * radius * radius;
Console.WriteLine(area);


////////////Branch and loops///////////
// if condiiton 
int ab = 5;
int bc = 1;
int cd = ab + bc;
if (cd > 10)
{
    Console.WriteLine("the value is greater than 10");
}
else
{
    Console.WriteLine("the value us less than 10");
}

int A = 5;
int B = 3;
int C = 4;

if ((A + B + C > 10) || (A == 10))
{
    Console.WriteLine("the answer is greater than 10");
    Console.WriteLine("The first number is equal to second");
}
else
{
    Console.WriteLine("The anser is not greater than 10");
    Console.WriteLine("The first number is not equal to second");
}

// while loop
int counter = 0;
counter++;
Console.WriteLine(counter);
counter++;
Console.WriteLine(counter);
counter++;
Console.WriteLine(counter);
counter++;
Console.WriteLine(counter);
counter++;
Console.WriteLine(counter);
counter++;
Console.WriteLine(counter);

int counter1 = 0;
while (counter1 < 5)
{
    Console.WriteLine(counter1);
    counter1 = counter1 + 1;
}

int counter2 = 10;
do
{
    Console.WriteLine($"Hello world !, the counter is {counter2}");
    counter2++;
} while (counter2 < 10);

// for loop 
for (
    int i = 0; // initialisation (start)
    i < 10; // condition
    i++) // iteration
{
    Console.WriteLine(i);
}


for (int ij = 0; ij < 5; ij++)
{
    if (ij == 3)
    {
        Console.WriteLine(ij);
    }
}

// nested for loop
for (int row = 1; row < 11; row++)
{
    for (char column = 'a'; column < 'k'; column++)
    {
        Console.WriteLine($"The cell is ({row}, {column})");
    }
}


for (int t = 1; t < 21; t++)
{
    if (t % 3 == 0)
    {
        Console.WriteLine(t);
    }
}

int r = 1;

while (r < 20)
{
    if (r % 3 == 0)
    {
        Console.WriteLine(r);
    }
    r++;
}

// challange
int sum = 0;
for (int i = 1; i < 20; i++)
{
    if (i % 3 == 0)
    {
        sum = sum + i;
    }
}
Console.WriteLine($"The sum is {sum}");


var names = new List<string> { "bhaskar", "ana", "Honey" };
names.Add("Ram");
names.Add("chandan");
names.Remove("ana");
// foreach (var name in names)
// {
//     Console.WriteLine($"The names in list are {name.ToUpper()}!!");
// }

Console.WriteLine($"My name is {names[0]}.");
Console.WriteLine($"I've added {names[2]} and {names[3]} to the list.");
Console.WriteLine($"The list has {names.Count} people in it");
Console.WriteLine(names[^2]);

// array - bucket of anything like list arrya are fixed in length
var names1 = new string[] { "Bhaskar", "Ram", "Chandan", "Honey" };
//names1 = [..names1, "Shiva"]; //to add values in arrys 
foreach (var name in names1)
{
    Console.WriteLine($"Hello, {name}");
}

// searching and sorting

var names2 = new List<string> { "Happy", "Ram", "Chandan", "Jay" };
names2.Sort();
foreach (var name in names2)
{
    Console.WriteLine(name);
}

var numbers = new List<int> { 45, 56, 99, 48, 67, 78 };
Console.WriteLine($"I found 2 at {numbers.IndexOf(99)}");
numbers.Sort();
Console.WriteLine($"I found 2 at {numbers.IndexOf(99)}");
// Console.WriteLine(numbers.IndexOf(2));
// foreach (var number in numbers)
// {
//     Console.WriteLine(number);
// }


var names3 = new List<string> { "Sajal", "Siva", "Ritwiz", "Mansi" };
names3.Sort();
// Console.WriteLine(names3.IndexOf("Sajal"));
foreach (var name in names3)
{
    Console.WriteLine(name);
}

// fibonacciNumbers
var fs = new List<int> { 1, 1 };

while (fs.Count < 20)
{
    var prev = fs[^1];
    var prev2 = fs[^2];
    fs.Add(prev + prev2);
}

foreach (var item in fs)
{
    Console.WriteLine(item);
}


/// gettign list of score greater than 80
var scores = new List<int> { 97, 92, 81, 60 };
for (int i = 0; i < scores.Count; i++)
{
    if (scores[i] > 80)
    {
        Console.WriteLine($"Found the scores greater than 80 {scores[i]}");
    }
}

var scores1 = new List<int> { 97, 92, 81, 60 };
for (int i = 0; i < scores1.Count; i++)
{
    if (scores1[i] > 80)
    {
        Console.WriteLine($"found somthing {scores[i]}");
    }
}

// Specify the data source
var scores2 = new List<int> { 97, 92, 81, 60 };

// scores2.Sort();

// Definig the query expression 
IEnumerable<int> scorequery =
    from score in scores2
    where score > 30
    orderby score descending
    select score;

// Execute the query 
foreach (int score in scorequery)
{
    Console.WriteLine(score);
}


var string2 = new List<int> { 97, 92, 81, 60, 99 };

IEnumerable<string> scorequery1 =
    from str in string2
    where str > 80
    orderby str ascending
    select $"The score is {str}";

Console.WriteLine(scorequery1.Count());


foreach (string str in scorequery1)
{
    Console.WriteLine(str);
}




