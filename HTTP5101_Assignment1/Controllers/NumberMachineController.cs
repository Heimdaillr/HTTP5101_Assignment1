using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5101_Assignment1.Controllers
{
    public class NumberMachineController : ApiController
    {
        /// <summary>
        /// created a basic arthimetic problem that adjusts the user input with 4 different 
        /// mathematical operations. set up to accept an integer input and return an integer
        /// referred to w3school and notes, troubleshoot till resolved to proper output
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        //GET api/numbermachine/id
        public int Get(int id)
        {
            return 5 + (((id * 3) / 2) - 3);
        }
    }
}