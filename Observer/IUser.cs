using app1.Adapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app1.Observer
{
    interface IUser
    {
        string Name { get; }
        void Subscribe(INotification notification);

        
    
    }
}

