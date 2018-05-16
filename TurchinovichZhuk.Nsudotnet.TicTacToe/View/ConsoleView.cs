using System;


namespace TurchinovichZhuk.Nsudotnet.TicTacToe.View
{
    public class ConsoleView
    {

        public void ShowRules()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Hello, lets have some fun!");
            Console.WriteLine("We are going to play in TicTacToe and rules are very simple:");
            Console.WriteLine("We have big field with 9 simple Tic Tac Toe fields.");
            Console.WriteLine("Win little field - get one point on big one!");
            Console.WriteLine("You can go only the same cell that was chosen in little field!");
            Console.WriteLine("Enter your step with two numbers and space between followed dy Enter.");
            Console.WriteLine("Good Luck!");
        }

        public int[] GetSteps()
        {
            string input = Console.ReadLine();
            string[] stepStrings = input.Split(' ');
            int outsideStep;
            int insideStep;
            int[] steps = new int[2];
            if (Int32.TryParse(stepStrings[0], out outsideStep) && Int32.TryParse(stepStrings[1], out insideStep))
            {
                steps[0] = outsideStep;
                steps[1] = insideStep;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wrong format, lets try again!");
                steps = GetSteps();
            }
            return steps;
        }
        
        

    }
}