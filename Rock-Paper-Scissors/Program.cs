using System;

namespace Rock_Paper_Scissors
{
    					
    public class Program
    {
	    public static void Main()
	    {


		    bool playAgainOption = false;
		    do
		    {
			Console.WriteLine("This is a prototype for Rock-Paper-Scissors Game. Please select one option:");
		
			Console.WriteLine("Rock (1)");
			Console.WriteLine("Paper (2)");
			Console.WriteLine("Scissors (3)");

			//Console.WriteLine("Select your option:");
			string userOption;
			userOption = Console.ReadLine();
			int option = 0;
			bool result = Int32.TryParse(userOption, out option);
			
            //validate option from user, is a number? is 1 2 3?
			//throw new Exception($"option is not correct, try again");

			Console.WriteLine("Your option is: " + option);
     		//Console.ReadLine();
			
			Random computerOption = new Random();
			int co = computerOption.Next(1,4);
			Console. WriteLine("The option from Computer is: " + co);

			if ((option == 1) && (co == 1))
			{
				Console.WriteLine("Tie with Rocks");
			}
			else if ((option == 1) && (co == 2))
			{
				Console.WriteLine("Sorry, you lose, because Paper wins Rock");
			}
			else if ((option == 1) && (co == 3))
			{
				Console.WriteLine("Congrats! :D, you win, because Rocks wins Scissors");
			}

			else if ((option == 2) && (co == 2))
			{
				Console.WriteLine("Tie with Pappers");
			}
			else if ((option == 2) && (co == 1))
			{
				Console.WriteLine("Congrats! :D, you win, because Paper wins Rock");
			}
			else if ((option == 2) && (co == 3))
			{
				Console.WriteLine("Sorry, you lose, because Scissors wins Paper");
			}

			else if ((option == 3) && (co == 3))
			{
				Console.WriteLine("Tie with Scissors");
			}
			else if ((option == 3) && (co == 1))
			{
				Console.WriteLine("Sorry, you lost, because Rock wins Scissors");
			}
			else if ((option == 3) && (co == 2))
			{
				Console.WriteLine("Congrats! :D, you win, because Scissors wins Paper");
			}
			//else Console.WriteLine
			Console.WriteLine();

			Console.WriteLine("Do you wanna play again?: [Y] Yes, [Any other key] No.");
			string userAnswer = Console.ReadLine();
			playAgainOption = userAnswer.Trim().ToUpper() == "Y";

			//if (playAgainOption.Trim().ToUpper() == "Y")
			//{
			//	Console.WriteLine("LOOP");				
			//}
			//if (playAgainOption.Trim().ToUpper() == "N")
			//{
			//	Console.WriteLine("OK. Bye!");
			//}

			//input from user
			//generar random value
			//compare
			//show winner
			//un loop para saber cuando parar de jugar, 

		}
		while (playAgainOption);
		    Console.WriteLine("OK. Bye!");
			
		}
		
    }
}
    

