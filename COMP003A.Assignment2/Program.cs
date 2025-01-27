﻿namespace COMP003A.LectureActivity2;
// Author: Raymond Gonzalez
// Course: COMP-003A
// Faculty: Johnathan Cruz
// Purpose: To learn and demonstrate how to use statements, variables, data types, and operators while simulating a real-world scenario
class Program
{
    static void Main(string[] args)
    {
        // Declare and initialize variables
        string userName; // Variable to store the user's name
        int userAge; // Variable to store the user's age
        double productPrice; // Variable to store the product price
        bool isStudent; // Variable to store if the user is a student (true/false)
        
        // Prompt the user to enter their name
        Console.Write("Enter your name: ");
        userName = Console.ReadLine(); // Read and assign the user's input to userName
        
        // Prompt the user to enter their age
        Console.Write("Enter your age: ");
        userAge = int. Parse(Console.ReadLine()); // Convert and assign the user's input to userAge
        
        // Prompt the user to enter the product price
        Console.Write("What is the price of the item you are interested in?: ");
        productPrice = double. Parse(Console.ReadLine()); // Convert and assign the user's input to productPrice
        
        // Prompt the user to indicate if they are a student
        Console.Write("Are you a student? (true/false): ");
        isStudent = bool. Parse(Console.ReadLine()); // Convert and assign the user's input to isStudent
        
        // Perform calculations

        int futureAge = userAge + 5; // Calculate the user's age in 5 years
        bool isAdult = userAge >= 18; // Determine if the user is 18 or older
        bool isAdultStudent = isStudent && isAdult; // Determine if the user is both a student and an adult
        bool isSenior = userAge >= 60; // Determine if the user is 60 or over
        double studentDiscount = productPrice * 0.9; // Student discount calculation
        double seniorDiscount=productPrice * 0.8; // Senior discount calculation
        
        
        

        // Display outputs 
        Console.WriteLine($"\nHello, {userName}!"); // Greet the user with their name
        Console.WriteLine($"You are currently {userAge} years old. In 5 years, you will be {futureAge}."); // Display current and future age
        Console.WriteLine($"Are you 18 or older? {isAdult}"); // Display if the user is 18 or older
        Console.WriteLine($"The original price of the item is ${productPrice}"); // Display the original price
        
        if (isStudent == true)
        {
            Console.WriteLine($"As a student, your discounted price is ${studentDiscount}");
        }
        // Display discounted price if student = true
        if (isSenior == true)
        {
            Console.WriteLine($"As a senior citizen your discounted price is ${seniorDiscount}");
        }
        // Display discounted price of senior if age  >=60 

        
       
        
    }
}