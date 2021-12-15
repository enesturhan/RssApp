using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RssApp.Models
{
    public class New
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();

        public string NewsName { get; set; }
        public string RssLink { get; set; }

        public string Priority { get; set; }


    }
}
