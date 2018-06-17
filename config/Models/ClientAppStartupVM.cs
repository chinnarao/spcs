using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace config.Models
{
    public class ClientAppStartupVM
    {
        public string SignUpUrl { get; set; }
        public string LoginUrl { get; set; }
        public string AppBaseUrl { get; set; }
        public string Facebook { get; set; }
        public string Google { get; set; }
        public string LinkedIn { get; set; }
        public string Microsoft { get; set; }
    }
}
