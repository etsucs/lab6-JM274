/**       
 *--------------------------------------------------------------------
 * 	   File name: Homework6
 * 	Project name: Lab6
 *--------------------------------------------------------------------
 * Author’s name and email:	Jacob Malone, maloneje@etsu.edu	
 *          Course-Section: CSCI-1250-001
 *           Creation Date:	3/23/2022	
 * -------------------------------------------------------------------
 */
//Method1
ShowCharacter("Johnson", 4);

//Method2
Console.WriteLine("Enter a wholesale cost: ");
double cost = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter the markup percent: ");
double percent = Convert.ToDouble(Console.ReadLine());
CalculateRetail(cost, percent);

//Method3
for (int i = 80; i <= 100; i++)
{
    Console.WriteLine($"{i} converted to Celsius is {Math.Round(Celsius(i), 2)}");
}
//Method4
IsPrime();

//Method1
static void ShowCharacter(string word, int letter)
{
    if(letter > word.Length)
    {
        Console.WriteLine("Error, wrong length");
    }
    else if(letter <= 0)
    {
        Console.WriteLine("Error, wrong length");
    }
    else
    {
        Console.WriteLine($"The letter in the {letter} place is {word[letter - 1]}");
    }
}

//Method2
static void CalculateRetail(double cost, double percent)
{
    double percentage = percent / 100;
    double totalPrice = cost + (cost * percentage);
    Console.WriteLine($"The total cost is ${totalPrice}");
}

//Method3
static double Celsius(double far)
{
    var cel = 5.0 / 9.0 * (far - 32.0);
    return cel;
}
//Method4
static void IsPrime()
{
    Console.WriteLine("Enter a prime whole number.");
    int num = Convert.ToInt32(Console.ReadLine());
    if(num == 0 || num == 1)
    {
        Console.WriteLine("False");
    }
    else
    {
        for (int i = 2; i <= num / 2; i++)
        {
            if (num % i == 0)
            {
                Console.WriteLine("False");
                return;
            }
        }
        Console.WriteLine("True");
    }

}
