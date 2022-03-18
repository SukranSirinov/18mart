using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6
{
    internal class Employee
    {
        private string _name;
        private string _surname;
        private double _salary;
        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                if (CheckTextFormat(value))
                {
                    this._surname = value;
                }
            }
        }
        public double Salary
        {
            get
            {
                return this._salary;

            }
            set
            {
                if (value > 250)
                {
                    this._salary = value;
                }
            }
        }
        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                if (CheckTextFormat(value))
                {
                    this._name = value;
                }
            }
        }
        public bool CheckTextFormat(string text)
        {
            if (string.IsNullOrEmpty(text) && char.IsUpper(text[0]))
            {
                for (int i = 0; i < text.Length; i++)
                {
                    if (!char.IsLetter(text[i]))
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }
        

    }
}
