using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diary.Models.Domains
{
    public class ConnectionConfig
    {
        public string ServerAdress { get; set; }
        public string ServerName { get; set; }
        public string DataBaseName { get; set; }
        public string UserId { get; set; }
        public string Password { get; set; }
    }
}
