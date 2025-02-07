// CEIS209 Course Project
// Module 1
// Introduction to Software Development Tools
// Topics: Data Types, Variables, and Assignment Statements

// Define constants - Update Code with Your Information
const string userName = "Clayton Seeber"; // Replace with your name
const string userCourseNumber = "CEIS209";
const string userSession = "January 2025"; // Replace with the session month and year

// Declare Variables - Enter Code Below
string? loanProvider = Console.ReadLine();
string? loanPurpose = Console.ReadLine();
string? loanAccountNumber = Console.ReadLine();
DateTime loanDate = Convert.ToDateTime(Console.ReadLine());
decimal loanAmount = Convert.ToDecimal(Console.ReadLine());
decimal loanInterestRate = Convert.ToDecimal(Console.ReadLine());
decimal loanTerm = Convert.ToDecimal(Console.ReadLine());
decimal loanPayment = Convert.ToDecimal(Console.ReadLine());





//Clear Screen - This code is complete. Do not change.
Console.Clear();

// Display Welcome Message - Enter Code Below
Console.WriteLine("Welcome to the Loan Tracker!");
Console.WriteLine("This program will help you track your organization's loans,including the principal, interst rate, term, payment, and amortization of each loan.");
Console.WriteLine("Loan Information -----");
Console.WriteLine("Please enter the provider of the loan:");
Console.WriteLine("Please enter the purpose of the loan:");
Console.WriteLine("Please enter the account number of the loan:");
Console.WriteLine("Please enter the initiation date of the loan:");Console.ReadLine("Please enter the loan amount:");
Console.WriteLine("Please enter the interest rate:");
Console.WriteLine("Please enter the loan term in years:")



// Clear the Screen - Enter Code Below
Console.Clear();
// Get Loan Information - Enter Code Below
Console.WriteLine("Loan Information---");
Console.WriteLine("Loan Provider:" + loanProvider);
Console.WriteLine("Loan Purpose:" + loanPurpose);
Console.WriteLine("Loan Account Number:" + loanAccountNumber);
Console.WriteLine("Loan Date:" + loanDate);
Console.WriteLine("Loan amount;" + loanAmount);
Console.WriteLine("Interest Rate:" + loanInterestRate);
Console.WriteLine("Loan Term:"+ loanTerm);
Console.WriteLine("Monthly payment" + loanPayment);




// Calculate Monthly Payment - This code is complete. Do not change.
decimal monthlyInterestRate = loanInterestRate / 1200;
decimal numberOfPayments = loanTerm * 12;
loanPayment = loanAmount * (monthlyInterestRate * (decimal)Math.Pow((double)(1 + monthlyInterestRate), (double)numberOfPayments)) / ((decimal)Math.Pow((double)(1 + monthlyInterestRate), (double)numberOfPayments) - 1);

// Clear the Screen - Enter Code Below
Console.Clear();
// Display User Information - This code is complete. Do not change.
Console.WriteLine();
Console.WriteLine("User Information ---");
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Welcome " + userName + "!");
Console.WriteLine("Course: " + userCourseNumber);
Console.WriteLine("Session: " + userSession);
Console.WriteLine(DateTime.Now);
Console.ResetColor();

// Display Loan Information - This code is complete. Do not change.
Console.WriteLine();
Console.WriteLine("Loan Information ---");
Console.WriteLine("Loan Provider: " + loanProvider);
Console.WriteLine("Loan Purpose: " + loanPurpose);
Console.WriteLine("Loan Account Number: " + loanAccountNumber);
Console.WriteLine("Loan Date: " + loanDate.ToShortDateString());
Console.WriteLine("Loan Amount: $" + loanAmount);
Console.WriteLine("Interest Rate: " + loanInterestRate + "%");
Console.WriteLine("Loan Term: " + loanTerm + " years");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Monthly Payment: $" + Math.Round(loanPayment, 2));
Console.ResetColor();
Console.WriteLine();

// Display Goodbye Message - Enter Code Below


Console.WriteLine("Thank you for using Loan Tracker!");