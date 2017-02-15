using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDIParentExample
{
    public class MDISingleton
    {
        private MDISingleton() { }

        private static MDIParent1 instanceMdiParent;

        public static MDIParent1 InstanciaMdi()
        {
            if (instanceMdiParent == null)
            {
                instanceMdiParent = new MDIParent1();
                return instanceMdiParent;
            }
            else
            {
                return instanceMdiParent;
            }
        }
    }
}
