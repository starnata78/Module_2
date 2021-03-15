using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Module_2.Controllers
{
    public class Module_2Controller : ApiController
    {
        //Get api/Module_2/5
        /// <summary>
        /// Halves the input number and rounds it up
        /// </summary>
        /// <param name="id">the input number</param>
        /// <returns>half of the input number (rounded up)</returns>
        /// <example>Get api/Module_2/11 -> 5</example>
        public int GetHalfUp(int id)
        {
            decimal quotient = (decimal)id / 2;
            quotient = Math.Ceiling(quotient);
            return (int)(quotient);
        }
        /// <summary>
        /// Halves the input number and rounds it down
        /// </summary>
        /// <param name="id">the input number</param>
        /// <returns>half of the input number (rounded down)</returns>
        /// <example>Get api/Module_2/11 -> 5</example>
        public int GetHalfDown(int id)
        {
            decimal quotient = (decimal)id / 2;
            quotient = Math.Floor(quotient);
            return (int)(quotient);
        }
        /// <summary>
        /// Squares the input number.
        /// </summary>
        /// <param name="id">the input number</param>
        /// <returns>input number squared</returns>
        /// <example>Get api/Module_2/5 -> 25</example>
        public int GetSquare(int id)
        {
            int a = id * id;
            return a;
        }
        /// <summary>
        /// Output a sentence with input integer inluded in it.
        /// </summary>
        /// <param name="id">the input integer</param>
        /// <returns>the sentence with says "Your input number is x!" where x is the input integer</returns>
        /// <example>Get api/Module_2/GetInputNum/5 - Your input number is 5! </example>
        public string GetInputNum (int id)
        {
            int b = id;
            string message = "Your input number is " + b.ToString() + "!";
            return message;
        }
    }
}


