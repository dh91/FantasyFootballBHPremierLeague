﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace FFBHPL
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ISessionService" in both code and config file together.
    [ServiceContract]
    public interface ISessionService
    {
        [OperationContract]
        bool Login(String user, String password);
          [OperationContract]
        bool Logout(String user);
    }
}
