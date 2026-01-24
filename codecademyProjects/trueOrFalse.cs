using System;

class TrueOrFalse
{
  public static void Run()
  {
    Console.WriteLine("Running True or False...");

    Console.WriteLine("Welcome to 'True or False?'\nPress Enter to begin:");
    Console.ReadLine();
    
    // Test Questions
    string[] questions = new string[] {
    "True or False: C# is a strongly typed language.",
    "True or False: In C#, you can store multiple data types in an int variable.",
    "True or False: A string in C# is written inside double quotes.",
    "True or False: bool variables can only be true or false.",
    "True or False: Arrays in C# have a fixed size once created.",
    "True or False: Console.WriteLine() prints text to the console.",
    "True or False: In C#, index counting for arrays starts at 1.",
    "True or False: You must end most C# statements with a semicolon (;).",
    "True or False: '==' is used to compare two values in C#.",
    "True or False: You can declare a variable without giving it a type in C#."
    };

    // Test Answers
    bool[] answers = new bool[] {
    true,   // C# is strongly typed
    false,  // int can only store integers
    true,   // strings use double quotes
    true,   // bool = true/false only
    true,   // arrays are fixed size
    true,   // prints to console
    false,  // indexing starts at 0
    true,   // semicolons end statements
    true,   // == compares values
    false   // must declare type (unless using var)
    };

    // User Responses to be stored
    bool[] responses = new bool[questions.Length];
    
    // catchall for length of question and answer arrays
    if ( questions.Length != answers.Length)
    {
      Console.WriteLine("Error: Please Update Questions and Answers");
      return;
    }

    // keeps track of asked questions
    int askingIndex = 0;

    // asking questions and tracking answers
    foreach (string question in questions)
    {
      string input = " ";
      bool isBool = false;
      bool inputBool = false;

      // checks to see if response is a boolean
      while(isBool == false)
      {
        Console.WriteLine($"{question}");
        input = (Console.ReadLine() ?? "").ToLower();
        
        if (input == "true" || input == "false")
        {
          isBool = true; 
        }
        else
        {
          Console.WriteLine("Please enter 'true' or 'false'.");
        }
      }

      // Stores answers in 'responses'
      if(input == "true")
      {
        inputBool = true;
      }
      else
      {
        inputBool = false;
      }
      responses[askingIndex] = inputBool;

      askingIndex++;
    }

    // calculating score
    int scoringIndex = 0;
    int score = 0;

    Console.WriteLine("YOU HAVE FINISHED THE QUIZ!\n Here are your results:\n");
    foreach (bool response in responses)
    {
      if (response == answers[scoringIndex])
      {
        score++;
      }
      
      Console.WriteLine($"Input: {response} | Answer: {answers[scoringIndex]}");
      scoringIndex++;
    }

      Console.WriteLine($"You Scored {score} out of {questions.Length}");
  }
}