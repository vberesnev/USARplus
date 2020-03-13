using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USAR_TestProject.Model
{
    class Message: IMessage
    {
        public string Text { get; set; }
        public string UserName { get; set; }
        public DateTime SaveDate { get; set; }

        public Message() { }
    }
}
