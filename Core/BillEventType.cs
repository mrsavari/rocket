using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Data;

namespace Rocket.Core
{
    public enum BillEventType
    {
        Create = 1,
        Edit = 2
    }
}