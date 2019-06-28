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
    public partial class ucShare : UserControl
    {
        //Singleton pattern
        private static ucShare _instance;
        public static ucShare Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ucShare();
                }
                return _instance;
            }
        }
        public ucShare()
        {
            InitializeComponent();
        }
    }
}
