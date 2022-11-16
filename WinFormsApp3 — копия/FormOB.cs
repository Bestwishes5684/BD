using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp3
{
    public enum FormOB
    {
        /// <summary>
        /// очная
        /// </summary>
        [Description("очная")]
        fulltime,
        /// <summary>
        /// Заочная
        /// </summary>
        [Description("Заочная")]
        correspondence,
        /// <summary>
        /// очно-заочно
        /// </summary>
        [Description("Очно-заочно")]
        both
    }
}
