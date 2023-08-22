using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app1.Adapter
{
    interface INotification
    {
        void Send( string subject, string message);
    }
}
