using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spiski
{
    class Head
    {
        int info;
        Head next;
        #region свойства
        public int Info
        {
            get { return info; }
            set { info = value; }
        }
        public Head Next
        {
            get { return next; }
            set { next = value; }
        }
        #endregion
        #region Конструктор без параметров
        public Head()
        {
            info = default(int);
            next = null;
        }
        #endregion
        #region Преобразование в строку
        public override string ToString()
        {
            return info + " ";
        }
        #endregion
    }
}
