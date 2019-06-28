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
    public partial class ucHome : UserControl
    {
        //Singleton pattern
        private static ucHome _instance;
        public static ucHome Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ucHome();
                }
                return _instance;
            }
        }
        public ucHome()
        {
            InitializeComponent();
        }
    }
}
