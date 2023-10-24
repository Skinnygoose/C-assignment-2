using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace assignment_2.Controllers
{
    public class J1ProblemController : ApiController

    /// <summary>
    /// Calculates if on the basis of input dog will be hapy or sad
    /// </summary>
    /// <param small="integer">number of small size treats less than 10</param>
    /// <param medium="integer">number of medium size treats </param>
    /// <returns>strings which will tell the dog mood   {Value}.</returns>
    /// <example>
    /// GET api/problem/dogtreat/{small}/{medium}/{large} ->1,2,3
    /// "sad"
    
    {
        [HttpGet]
        [Route("api/problem/dogtreat/{small}/{medium}/{large}")]

        public string  dogtreat(int small ,int medium ,int large)

        {

            if (small < 10 && medium < 10 && large < 10)
            {
                int result = (small * 1 + medium * 2 + large * 3);
                if (result >= 10)
                {
                    return "Happy";

                }
                else
                    return "Sad";

            }
            else return "Input must be less than 10";
           
            
                


        }
        /// <summary>
        /// Calculates the number of days it will take for the disease to spread based on number of people initially affected and how many people get affected at once
        /// </summary>
        /// <param P="integer ">total number of people that get affected after certain days</param>
        /// <param N="integer">number of infected people on day 0 </param>
        /// <param R="integer">number of people that get affected by disease</param>
        /// <returns>Number of days it will take the disease to  spread to number of people    {Value}.</returns>
        /// <example>
        /// GET api/problem/epidemic/{P}/{N}/{R} ->750,1,5
        /// "4"
        //

        [HttpGet]
        [Route("api/problem/epidemic/{P}/{N}/{R}")]

        public string epidemic (int P , int N , int R) { 
        
            int value = N;
            int finalvalue = 0; 
            int days = 0;
            if (P <= 10000000 && N <= P && R <= 10)
            {
                while (finalvalue < P)
                {
                    value = value * R;
                    finalvalue = finalvalue + value;
                    days += 1;


                }
                return ("" + days);


            }
            else return ("ERROR");





            }






    }
}
