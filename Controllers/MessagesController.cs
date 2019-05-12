using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MvcDemo.Controllers
{
    public class MessagesController : ApiController
    {
        List<String> messages = new List<String>()
        {
            "First Message", "Second Message", "Third Message"
        };

        // Get /api/Messages
        public List<String> Get()
        {
            return messages;
        }


        // Get /api/Messages/1
        public String Get(int id)
        {
            if (id <= messages.Count())
                return messages[id - 1];
            else
                throw new HttpResponseException(HttpStatusCode.NotFound);

        }
    }
}
