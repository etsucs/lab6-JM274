/**       
 *--------------------------------------------------------------------
 * 	   File name: Homework7
 * 	Project name: Lab7
 *--------------------------------------------------------------------
 * Author’s name and email:	Jacob Malone, maloneje@etsu.edu	
 *          Course-Section: CSCI-1250-001
 *           Creation Date:	3/30/2022	
 * -------------------------------------------------------------------
 */
CountSheep();
XOChecker();

//Method1
static void CountSheep()
{
   Console.WriteLine("How many sheep?");
   int sheep = Convert.ToInt32(Console.ReadLine());
   if (sheep > 0)
   {
       for (int i = 1; i != sheep + 1; i++)
       {
           Console.Write($"{i} sheep... ");
       }
       return;
   }
}

//Method2
static void XOChecker()
{
    Console.WriteLine("Enter a string of letters");
    string letters = Console.ReadLine();
    string[] xCharacters = letters.Split('x','X');
    string[] oCharacters = letters.Split('o','O');
    if (xCharacters.Length == oCharacters.Length)
    {
        Console.WriteLine("True");
    }
    else
    {
        Console.WriteLine("False");
    }
}
