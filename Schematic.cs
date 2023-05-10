
using System.Net;
/// <summary>
/// Author: Ryan Dalrymple
/// Date: 5/9/23
/// Copyright: Ryan Dalrymple - This work may not be copied for use
/// 
/// File Contents
/// 
///     This file represents a circuit diagram provided on the questionnaire. 
/// </summary>

/// <summary>
/// Represents if the button is pushed or not, normally open.
/// </summary>
bool isPressed = false;

/// <summary>
/// Represents if a user chooses to push the button
/// Y (or y) means yes, and the button is pushed.
/// N (or n) means no, and the button is not pushed.
/// </summary>
string userResponse = "";

/// <summary>
/// Determines whether a user's response is valid for pushing the button.
/// </summary>
bool validResponse = false;

while(true)
{
    if(!isPressed)
    {
        Console.WriteLine("The button PB100 is not pushed.");
        Console.WriteLine("CR100 is de-energized.");
        Console.WriteLine("LT106 is illuminated, and LT104 is not.");
    }
    else if(isPressed)
    {
        Console.WriteLine("The button PB100 is pushed.");
        Console.WriteLine("CR100 is energized.");
        Console.WriteLine("LT106 is not illuminated, and LT104 is illuminated.");
    }

    while (!validResponse)
    {
        Console.WriteLine("\nDo you want to push the button?");
        Console.WriteLine("Enter Y (or y) for yes.");
        Console.WriteLine("Enter N (or n) for no.");
        userResponse = Console.ReadLine();

        if (userResponse == null)
        {
            userResponse = "";
            continue;
        }
            
        else
        {
            userResponse = userResponse.Trim();
            userResponse = userResponse.ToLower();
        }

        if(userResponse == "y")
        {
            validResponse = true;
            isPressed = true;
        }
            
        if (userResponse == "n")
        {
            validResponse = true;
            isPressed = false;
        }
            
    }
    validResponse = false;
}
