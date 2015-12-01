/*
 * Author: Humzah Ali
 * Date: 23/11/15
 * Project: Social Security Check
 * File: SocialSecurityCheckProgram.cs
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;//import library to use regular expressions

namespace SocialSecurityCheck
{
    class SocialSecurityCheckProgram
    {
        internal Check Check
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
    
        static void Main(string[] args)
        {
            Console.Title = "Social Security Number Check";//change the console title

            bool repeatProg = true;//bool value for repeating the program

            do
            {
                string introText;//variable to store intro text
                string num;//number variable
                string repeatAns;//variable to store answer to repeat prompt

                introText = "This program is an Albanian social security number checker. "
                + "You will be asked\nto provide a social security number and the last character (the check letter)\nwill "
                + "determine if the number is valid or invalid.\n\nThe number you enter MUST be in the correct format."
                + "\nThe format is a 10 digit sequence of numbers followed by a letter.\n\nEXAMPLE: 1122334455J\n"
                + "\nYou MUST enter a valid number or you will be re-prompted.\n";//intro text

                Console.ForegroundColor = ConsoleColor.Green;//make intro text green
                Console.WriteLine(introText); //write intro text
                Console.ResetColor();//reset colour back to default

                do
                {
                    Console.Write("Enter an Albanian social security number: ");//prompt for number
                    num = Console.ReadLine().ToUpper();//read input and make it upper case
                }
                while (Regex.IsMatch(num, "^[0-9]{10}[A-Z]$") == false);//repeat the loop if input does not match regex pattern


                Check Albanian = new Check(num);//create instance of Check class

                //print if the number is valid or not
                Console.ForegroundColor = ConsoleColor.Yellow;//make text yellow to display answer
                Console.WriteLine("\nThe social security number \"{0}\" is {1}.", num, Albanian.CheckLetter() ? "vaild" : "not vaild");

                Console.ForegroundColor = ConsoleColor.Cyan;//make text cyan
                Console.Write("\nEnter 'exit' if you want to exit the program: ");//ask to restart
                repeatAns = Console.ReadLine().ToUpper();//get string value of input

                if (repeatAns == "EXIT")//if answer is exit
                    repeatProg = false;//repeat is false

                Console.Clear();//clear past user interactions
            } while (repeatProg == true);//end dowhile
        }//end main
    }//end class
}//end namespace
