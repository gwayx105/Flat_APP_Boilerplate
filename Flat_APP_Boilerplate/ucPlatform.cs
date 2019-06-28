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
    public partial class ucPlatform : UserControl
    {
        //Singleton pattern
        private static ucPlatform _instance;
        public static ucPlatform Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ucPlatform();
                }
                return _instance;
            }
        }
        public ucPlatform()
        {
            InitializeComponent();
        }
    }
}
