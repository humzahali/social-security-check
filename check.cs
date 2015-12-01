/*
 * Author: Humzah Ali
 * Date: 23/11/15
 * Project: Social Security Check
 * File: Check.cs
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;//import library to use regular expressions

namespace SocialSecurityCheck
{
    class Check
    {
        //attributes
        private string _givenNumber;
        private int _sum;

        //methods
        //constructor method
        public Check(string num)
        {
            this._givenNumber = num;
        }

        public bool CheckLetter()
        {
            for (int i = 0; i < 5; i++)
            {
                this._sum += Convert.ToInt32(this._givenNumber.Substring(i * 2, 2));//add 5 pairs of digits
            }//end for loop

            //check if index of check letter's ascii value is equal to calculation's value
            bool isValidNumber = (this._givenNumber[this._givenNumber.Length - 1] == (this._sum % 26) + 65);

            return isValidNumber;
        }//end CheckLetter method

        //property for Sum value
        public int Sum
        {
            get
            {
                return this._sum;
            }
        }

        //optional method that can be used to check number format
        public bool CheckNumberFormat()
        {
            //return bool value to see if number format has 10 letters followed by any uppercase char
            return Regex.IsMatch(this._givenNumber, "^[0-9]{10}[A-Z]$");
        }//end CheckNumberFormat method
    }//end class
}//end namespace
