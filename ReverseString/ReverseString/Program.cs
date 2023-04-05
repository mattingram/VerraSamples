// See https://aka.ms/new-console-template for more information

using System.Text;

string input = "Hellow world";


string ReverseString(string input)
{
	StringBuilder sb = new StringBuilder();
	for(int i = input.Length-1; i >= 0; i--)
	{
		sb.Append(input[i]);
	}
	return sb.ToString();
}

Console.WriteLine(ReverseString(input));