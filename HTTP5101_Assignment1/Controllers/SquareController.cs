using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5101_Assignment1.Controllers
{
    /// <summary>
    ///Basic arthimetic from the input of the user
    ///Square the users input, his is done just by multipling the input by itself. Achieving the same result as the power of 2.
    /// </summary>
    public class SquareController : ApiController
    {
        //GET api/square/id
        public int Get(int id)
        {
            return id * id;
        }
    }
}
