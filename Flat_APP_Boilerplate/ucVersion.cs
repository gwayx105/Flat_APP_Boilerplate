using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flat_APP_Boilerplate
{
    public partial class ucVersion : UserControl
    {
        //Singleton pattern
        private static ucVersion _instance;
        public static ucVersion Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ucVersion();
                }
                return _instance;
            }
        }
        public ucVersion()
        {
            InitializeComponent();
        }
    }
}
