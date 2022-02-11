using System.Collections.Generic;


Console.WriteLine("Please enter a phrase you would like to reverse: ");
string input = Console.ReadLine();
ReverseStack(input);


static string ReverseStack(string input)
{

    Stack<string> temp = new Stack<string>();
    string[] words = input.Split(' ');

    for (int i = 0; i < words.Length; i++)
    {
        temp.Push(words[i]);
    }

    while (temp.Count != 0)
    {
        Console.Write(temp.Peek() + " ");
        temp.Pop();
    }
    return input;
}














