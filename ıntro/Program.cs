// See https://aka.ms/new-console-template for more information
using ıntro.Businness;
using ıntro.Entities;

Console.WriteLine("Hello, World!");

string masagge1 = "Krediler";
int term = 12;
double amount = 100000;
//variables -->camelCase
bool İsAuhthenticated = false;
Console.WriteLine(masagge1);

//condition
if (İsAuhthenticated)
{
    Console.WriteLine("Buton-->Hoşgeldin Arda");
}
else
{
    Console.WriteLine("Buton-->Sisteme giriş yap");
}

string[] loans = { "Kredi 1", "Kredi 2", "Kredi 3", "Kredi 4", "Kredi 5", "Kredi 6" };
//string[]loans2 = nee string[6];
for (int i = 0; i < loans.Length; i++)
{
    Console.WriteLine(loans[i]);
}

course_manager course_Manager = new();
cour

course course1 = new course();  
course1.name = masagge1;        