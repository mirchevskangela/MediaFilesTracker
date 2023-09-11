using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace detectVideoApp
{
    public class DatabaseConfig
    {
        #region Members
        public String ServerName { get; set; }
        public String DatabaseName { get; set; }
        #endregion
    }
}
