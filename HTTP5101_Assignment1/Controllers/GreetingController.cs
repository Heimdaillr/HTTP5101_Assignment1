using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5101_Assignment1.Controllers
{
    public class GreetingController : ApiController
    {
        /// <summary>
        /// Initial trouble understanding how to call a Post, referred to class notes.
        /// Started with a get request to confirm appropriate output
        /// Started with 'string' since the output is a phrase
        /// Second public string combined the logic of the AddTen and the initial public string in this question
        /// First public requries not input and will return a string.
        /// Second public requires an integer input but outputs a concatenated string using the user input, had difficulty formatting the concatenation
        /// referred to w3school and notes, troubleshoot till resolved to proper output
        /// </summary>
        // POST api/greeting
        public string Post()
        {
            return "Hello World!";
        }

        // GET api/greeting/id
        public string Get(int id)
        {
            return "Greetings to " + id + " people!";
        }

    }
}
