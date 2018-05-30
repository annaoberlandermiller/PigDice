using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigDice
{
	class Program
	{

		Random rnd = new Random();//this is available to all methods, because it's inside of the class, but not in a specific method

		int RollDie()
		{
			return rnd.Next(1, 7);
		}

		void PlayPigDice()
		{
			int score = 0;
			int die = RollDie();
			while(die != 1) {
				score += die;
				die = RollDie();
			}
			Console.WriteLine("Score {0}", score);
		}

		void Run() {
			bool quit = false;
			while (!quit) {  //! means not - so this is saying not false(same as true), since we defined quit as false
				PlayPigDice();

				Console.Write("Do you want to quit?");
				string answer = Console.ReadLine();
				answer = answer.ToUpper();  //this is changing the response to uppercase
				quit = answer.StartsWith("Y");
			}
				
		}

		static void Main(string[] args)
		{
			(new Program()).Run(); //this calls the run method on line 10
		}
	}
}
