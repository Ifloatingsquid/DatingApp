using DatingApp.Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingApp.Shared.Domain
{
    public class Topic
    {
        public DateTime TimeStamp{ get; set; }
        public string TopicTitle { get; set; }
        public string TopicDesc { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}
