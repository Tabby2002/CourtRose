using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage?");
        string grade = Console.ReadLine();
        int percent = int.Parse(grade);

        string letter = "";

        if (percent >= 90)
        {
            if (percent < 93)
            {
                letter = "A-";
            }
            else
            {
                letter = "A";
            }
        }
        else if(percent >= 80 && percent < 90)
        {
            if (percent >= 87)
            {
                letter = "B+";
            }
            else if (percent < 83)
            {
                letter = "B-";
            }
            else
            {
                letter = "B";
            }
        }
        else if (percent >= 70 && percent < 80)
        {
            if (percent >= 77)
            {
                letter = "C+";
            }
            else if (percent < 73)
            {
                letter = "C-";
            }
            else
            {
                letter = "C";
            }
        }
        else if (percent >= 60 && percent < 70)
        {
            if (percent >= 67)
            {
                letter = "D+";
            }
            else if (percent < 63)
            {
                letter = "D-";
            }
            else
            {
                letter = "D";
            }
        }
        else
        {
            letter = "F";
        }

        if (percent >= 70)
        {
            Console.WriteLine($"Your grade is a {letter}. You passed the class. Yay, congradulations!!");
        }
        else
        {
            Console.WriteLine($"You have recieved a {letter}. You failed the class. I am sorry.");
        }

    }
}