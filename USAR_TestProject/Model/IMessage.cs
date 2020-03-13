using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USAR_TestProject.Model
{
    interface IMessage
    {
        string Text { get; set; }
        string UserName { get; set; }
        DateTime SaveDate { get; set; }
    }
}
