namespace BasicRockPaperScissors;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Program
{
	static void Main(string[] args)
	{
		string userSelection = string.Empty;
		string compSelection;
		Console.WriteLine("Welcome to Rock Paper Scissors with Allyn");
		bool selectionMade = false;
		bool isTie=false;
		do
		{
			Console.WriteLine("Please choose from the following options \n" +
				"1 - \"Rock\"\n" +
				"2 - \"Paper\"\n" +
				"3 - \"Scissors\"\n");
			string userNumber = Console.ReadLine();
			if (userNumber != null)
			{
				if (userNumber == "1" || userNumber == "2" || userNumber == "3")
				{
					userSelection = ConvertSelectionToOption(userNumber);
					selectionMade = true;
				}
			}
		} while (!selectionMade);

		compSelection = GetComputerOption();

		bool isWinner = GetWinner(isTie, userSelection, compSelection);

		if (isWinner)
		{
			Console.WriteLine("You win!");
		}
		else if (isTie)
		{
			Console.WriteLine("It's a tie");
		}
		else
		{
			Console.WriteLine("Youi lose");
		}
	}

	private static string ConvertSelectionToOption(string number)
	{
		switch (number)
		{
			case "1":
				return "Rock";
			case "2":
				return "Paper";
			case "3":
				return "Scissors";
			default:
				return string.Empty;
		}
	}
	private static string GetComputerOption()
	{
		Random rnd = new Random();
		int randomSelection = rnd.Next(1, 3);
		string randomNumber = randomSelection.ToString();
		return ConvertSelectionToOption(randomNumber);

	}
	private static bool GetWinner(bool isTie, string userSelection, string compSelection)
	{
		if (userSelection == "Rock" && compSelection == "Scissors" ||
			userSelection == "Paper" && compSelection == "Rock" ||
			userSelection == "Scissors" && compSelection == "Paper")
		{
			return true;
		}
		else if (userSelection == "Rock" && compSelection == "Paper" ||
				userSelection == "Paper" && compSelection == "Scissors" ||
				userSelection == "Scissors" && compSelection == "Rock")
		{
			return false;
		}
		else
		{
			isTie = true;
			return false;
		}
	}
}
