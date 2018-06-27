using System;
using System.Collections.Generic;
using System.Text;

namespace common.admodels
{
    public class Method_PostAd
    {
        public string Name { get; set; }
        public string Occupation { get; set; }

        public object ConvertToAnonymousType(Method_PostAd input)
        {
            return new { Name = input.Name, Occupation = input.Occupation  };
        }
    }
}
