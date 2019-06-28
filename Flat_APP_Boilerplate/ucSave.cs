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
    public partial class ucSave : UserControl
    {
        //Singleton pattern
        private static ucSave _instance;
        public static ucSave Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ucSave();
                }
                return _instance;
            }
        }
        public ucSave()
        {
            InitializeComponent();
        }
    }
}
