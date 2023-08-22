﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app1.Strategy
{
    interface INotificationStrategy
    {
        void SendNotification( string subject, string message);
    }
}
