using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurchinovichZhuk.Nsudotnet.TicTacToe.View;

namespace TurchinovichZhuk.Nsudotnet.TicTacToe
{
	class Program
	{
		static void Main(string[] args)
		{
			Model.Model model = new Model.Model();
			model.Init();
			View.ConsoleView view = new ConsoleView();
			
			Controller.Controller controller = new Controller.Controller(model, view);
//			Console.WriteLine(controller.MakeStep(0, 2));
//			Console.WriteLine(controller.MakeStep(2, 1));
			controller.StartGame();
		}
	}
}
