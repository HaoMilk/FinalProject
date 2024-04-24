using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Common.Const
{
    public static class StatusConst
    {
        #region User status
        public const string Waiting = "Waiting";
        public const string Active = "Active";
        public const string Inactive = "Inactive";
        public const string Deleted = "Deleted";
        #endregion User status

        #region Email status
        public const string Verified = "Verified";
        public const string NotVerified = "NotVerified";
        #endregion Email status
    }
}
