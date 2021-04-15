using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment6
{
    public static class Endpoints
    {

        public static string BaseUrl = "http://localhost:7071";

        public static string MessageSenderEndpoint { get; set; } = $"{BaseUrl}/Api/MessageSenderFunction/";
    }
}
