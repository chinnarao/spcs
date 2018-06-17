using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace SP.DL.Models
{
    public class ErrorResponseModel
    {
        public int Code { get; set; }
        public string Message { get; set; }
        public string Exception { get; set; }

        // other fields

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
