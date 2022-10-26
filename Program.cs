//Ayala Angelica
//10/24/22
//Mini Challenge #6 Even or ODD
//Created a function that will difine if the input is Even or Odd.
//Below I declared a function
//Created a user input
//I created an if statement to determine if the user input is even or odd


//Reviewed by: Mauricio Zavaña
//Date: 25/10/2022
//Review: Great job!!!


int result;
// Or I can have the numbers established, Number(10,5);

Console.WriteLine("Enter a number.");
result = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("The result is " + result);

//Below is asking if the number is even or odd
//The main method

if(result % 2 == 0)
{
    Console.WriteLine(result + "is an even number");
    
}
else
{
    Console.WriteLine(result + " is an odd number");
}
