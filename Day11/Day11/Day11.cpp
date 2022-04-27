// Day11.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include <vector>
using namespace std;//generally considered to be "bad"

enum class Superpower
{
    Swim = 1, Speed, Telepathy, Swinging, Money
};
void PrintPower(Superpower myPower)
{
    switch (myPower)
    {
    case Superpower::Swim:
        break;
    case Superpower::Speed:
        cout << (int)myPower << " Speedy\n";
        break;
    case Superpower::Telepathy:
        break;
    case Superpower::Swinging:
        break;
    case Superpower::Money:
        break;
    default:
        break;
    }
}
int main()
{
    Superpower powers = Superpower::Speed;
    PrintPower(powers);

    //template
    vector<int> scores;
    scores.push_back(5);
    scores.push_back(15);
    scores.push_back(235);
    scores.push_back(35);
    for (size_t i = 0; i < scores.size(); i++)
    {
        cout << scores[i] << " ";
    }
    cout << "\n";//Console.WriteLine();

    //std -- namespace
    //:: -- scope resolution operator. in C#, that is the '.'
    //cout -- console out. C#: Console.Write
    //<< -- insertion operator. inserting right side into the cout "stream"
    std::cout << "Hello World!\n" << 5 << "\nBatman rules. Spider-man swings.\n";

    cout << sizeof(char) << " (byte)\n";//wchar (wide char)

    int nums[] = { 1,2,3,4,5 };
    char best[] = "Batman";//\0 is null terminator
    char meh[] = { 'A','q','u','a','m','a','n' };
    cout << best << "\n" << meh << "\n";
    cout << sizeof(best) << "\n";
    cout << sizeof(nums) / sizeof(int) << "\n";

    //for loops are often used to index into an array
    //  for loop variable is just an index.
    //  indexes cannot be negative
    //  so...size_t is unsigned int
    for (size_t i = 0; i < 5; i++)
    {
    }

    srand(time(NULL));
    int rando = rand();//0-RAND_MAX
    int randMax = RAND_MAX;
    //limit rand to 0-1000
    //% - modulus
    rando = rand() % 1001;//0-1000
}

// Run program: Ctrl + F5 or Debug > Start Without Debugging menu
// Debug program: F5 or Debug > Start Debugging menu

// Tips for Getting Started: 
//   1. Use the Solution Explorer window to add/manage files
//   2. Use the Team Explorer window to connect to source control
//   3. Use the Output window to see build output and other messages
//   4. Use the Error List window to view errors
//   5. Go to Project > Add New Item to create new code files, or Project > Add Existing Item to add existing code files to the project
//   6. In the future, to open this project again, go to File > Open > Project and select the .sln file
