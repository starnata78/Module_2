using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Module_2.Controllers
{
    public class Assignment_1Controller : ApiController
    {
        //Question 1
        //Get api/Assignment_1/GetAddTen/{id}
        /// <summary>
        /// Returns 10 more than the integer input
        /// </summary>
        /// <param name="id">the input integer</param>
        /// <returns>Outputs 10 more than the input interger</returns>
        /// <example>Get api/Assignment_1/GetAddTen/5 -> 10</example>
        public int GetAddTen (int id)
        {
            int a = id + 10;
            return a;
        }
        //Question 2
        //Get api/Assignment_1/GetSquare/{id}
        /// <summary>
        /// Returns a square of the input integer
        /// </summary>
        /// <param name="id">the input integer</param>
        /// <returns>Outputs the square of the input integer</returns>
        /// <example>Get api/Assignment_1/GetSquare/5 -> 25</example>
        public int GetSquare (int id)
        {
            int b = id * id;
            return b;
        }
        //Question 2.1
        //Get api/Assignment_1/GetPow/{id}
        /// <summary>
        /// Returns a square of the input integer
        /// </summary>
        /// <param name="id">the input integer</param>
        /// <returns>Outputs the square of the input integer</returns>
        /// <example>Get api/Assignment_1/GetPow/5 -> 25</example>
        public double GetPow (int id)
        {
           double b = Math.Pow(id, 2);
            return b;
        }
        //Question 2.2
        //Get api/Assignment_1/GetPower/{numberBase}/{numberExponent}
        /// <summary>
        /// This function calculates the power of an input number
        /// </summary>
        /// <param name="numberBase">number</param>
        /// <param name="numberExponent">exponent</param>
        /// <returns>numberBase ^ numberExponent</returns>
        /// <example>Get api/Assignment_1/GetPower/5/2 -> 25</example>
        [Route("api/Assignment_1/GetPower/{numberBase}/{numberExponent}")]
        public double GetPower(double numberBase, double numberExponent)
        {
            double Power = Math.Pow(numberBase, numberExponent);
            return Power;
        }
        //Question 2.3
        //Get api/Assignment_1/GetSqrt/{id}
        /// <summary>
        /// Returns a square root of the input integer
        /// </summary>
        /// <param name="id">the input integer</param>
        /// <returns>Outputs the square of the input integer</returns>
        /// <example>Get api/Assignment_1/GetSqrt/25 -> 5</example>
        public double GetSqrt (int id)
        {
            double c = Math.Sqrt(id);
            return c;
        }
        
        //Post api/Assignment_1/PostGreeting
        /// <summary>
        /// Returns a message "Hello World! in Command Prompt"
        /// </summary>
        /// <returns>"Hello World!"</returns>
        /// <example>"api/Assignment_1/PostGreeting" --> 
        /// C:\Users\starn>curl "http://localhost:57633/api/Assignment_1/PostGreeting"
        /// {"Message:"The requested resource does not support http method 'GET'.'}
        /// C:\Users\starn>curl -d "" "http://localhost:57633/api/Assignment_1/PostGreeting"
        /// "Hello World!"
        /// C:\Users\starn>
        /// </example>
        public string PostGreeting()
        {
            string message = "Hello World!";
            return message;
        }
        //Question 4
        //Get api/Assignment_1/GetGreeting/{id}
        /// <summary>
        /// Returns a message = "Greetings to x people!" where x is the input integer.
        /// </summary>
        /// <param name="id">the input integer</param>
        /// <returns>Outputs "Greetings to x people!" where x is the input integer</returns>
        /// <example>Get api/Assignment_1/Greeting/5 -> Greetings to 5 people!</example>
        public string GetGreeting (int id)
        {
            int x = id;
            string message = "Greetings to " + x.ToString() + " " + "people!";
            return message;
        }
        //Question 5
        //Get api/Assignment_1/GetNumberMachine/{id}
        /// <summary>
        /// Applied four mathematical operations ("+", "-", "*", "/") to an input integer
        /// </summary>
        /// <param name="id">the input integer</param>
        /// <returns>Outputs a manupulated input integer</returns>
        /// <example>Get api/Assignment_1/GetNumberMachine/5 -> </example>
        public int GetNumberMachine (int id)
        {
            int a = 5;
            int b = 7;
            int c = 8;
            int d = 2;
            int e = ((id + a) - (id + b)) * c / d;
            return e;
        }
        //Question 6
        //Get api/Assignment_1/GetHostingCost/{id}
        /// <summary>
        /// The code calculates the total of hosting costs based on on the number 
        /// of days which have elepsed from the beginning of the hosting:
        /// 0-14 days = 1 fortnight
        /// 14-28 days = 2 fornights
        /// 
        /// </summary>
        /// <param name="id">the input integer</param>
        /// <returns>Outputs the breakdown of the total</returns>
        /// <example>Get api/Assignment_1/GetNumberMachine/5 -> 
        /// "1 fornights at $5.50/FN=$5.50 CAD"
        /// "HST 13% = 0.72 CAD"
        /// "Total = 6.22 CAD"
        /// </example>
        [Route("api/Assignment_1/GetHostingCost/{id}")]
        public string GetHostigCost(int id)
        {
            if (id<14)
            {
                return "1 fornights at $5.50 / FN =$5.50 CAD; " + "HST 13% = 0.72 CAD; " + "Total = 6.22 CAD.";
            } else if (id<27)
            {
                return "2 fornights at $5.50 / FN =$11 CAD; " + "HST 13% = 1.43 CAD; " + "Total = 12.43 CAD.";
            }
            else
            {
                return "3 fornights at $5.50 / FN =$16.50 CAD; " + "HST 13% = 2.14 CAD; " + "Total = 18.64 CAD.";
            }
             
        }
    }
}
