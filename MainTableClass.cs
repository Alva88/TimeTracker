using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace TimeTracker
{
    public static class MainTableClass
    {
        static DataTable _mTable = null;
        public static DataTable Maintable
        {
            get
            {
                return _mTable;
            }
            set
            {
                _mTable = value;
            }
        }
    }
}
