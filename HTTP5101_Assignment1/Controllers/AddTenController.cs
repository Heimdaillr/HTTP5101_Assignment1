using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5101_Assignment1.Controllers
{
    public class AddTenController : ApiController
    {
        //GET api/addten/id
        public int Get(int id)
        {
            return id + 10;
        }
    }
}
///<summary>
///Had trouble initiall settping up an Api Controller, default for program is MVC controller.
///Basic addition from the input of the user, referred to class notes 
///Initial attempt below, fixed the miscall for a returned string
/// public string Get(id)
///      {return int(id +10); }
///</summary>