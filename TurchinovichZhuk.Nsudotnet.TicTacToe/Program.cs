using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TurchinovichZhuk.Nsudotnet.TicTacToe
{
	class Program
	{
		static void Main(string[] args)
		{
			Model.Model model = new Model.Model();
			model.Init();
			Controller.Controller controller = new Controller.Controller(model);
			Console.WriteLine(controller.MakeStep(0, 2));
			Console.WriteLine(controller.MakeStep(2, 1));
		
			

		}
	}
}
