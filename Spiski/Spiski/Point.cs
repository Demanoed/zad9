using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spiski
{
    class Point
    {
        Head info;
        Point next;
        #region свойства
        public Head Info
        {
            get { return info; }
            set { info = value; }
        }
        public Point Next
        {
            get { return next; }
            set { next = value; }
        }
        #endregion
        #region Конструктор без параметров
        public Point()
        {
            info = null;
            next = null;
        }
        #endregion
    }
}
